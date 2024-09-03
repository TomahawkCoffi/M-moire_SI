using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mémoire_SI.Model
{

    internal class Fournisseur
    {
        public int FId { get; set; }
        public string Fnom { get; set; }
        public string Fadd { get; set; }
        public string Fcontact { get; set; }

        public SqlConnection con = DbConfig.con;

        public bool Save(Fournisseur four)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO fournisseurs_tbl(Fnom,Fadd,Fcontact)values(@FN,@FA,@FC)", con);
                cmd.Parameters.AddWithValue("@FN", four.Fnom);
                cmd.Parameters.AddWithValue("@FA", four.Fadd);
                cmd.Parameters.AddWithValue("@FC", four.Fcontact);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournissseur ajouté");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }

        public bool Update(Fournisseur four)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE fournisseurs_tbl SET Fnom=@FN,Fadd=@FA,Fcontact=@FC WHERE Fid=@Fkey", con);
                cmd.Parameters.AddWithValue("@FN", four.Fnom);
                cmd.Parameters.AddWithValue("@FA", four.Fadd);
                cmd.Parameters.AddWithValue("@FC", four.Fcontact);
                cmd.Parameters.AddWithValue("@Fkey", four.FId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Information du fournisseur modifiée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }

        public bool Delete(Fournisseur four)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM fournisseurs_tbl WHERE FId=@Fkey", con);
                cmd.Parameters.AddWithValue("@Fkey", four.FId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournissseur supprimé");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public List<Fournisseur> Get()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * from fournisseurs_tbl", con);
                adap.Fill(dt);
                con.Close();
                List<Fournisseur> fours = new List<Fournisseur>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Fournisseur four = new Fournisseur();
                    var row = dt.Rows[i];
                    four.FId = int.Parse(row["FId"].ToString());
                    four.Fnom = row["Fnom"].ToString();
                    four.Fadd = row["Fadd"].ToString();
                    four.Fcontact = row["Fcontact"].ToString();
                    fours.Add(four);
                }
                return fours;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }

        }

        public Fournisseur FindOneById(int key)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter($"SELECT * from fournisseurs_tbl WHERE FId={key}", con);
                adap.Fill(dt);
                con.Close();
                List<Fournisseur> fours = new List<Fournisseur>();

                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Fournisseur four = new Fournisseur();
                    var row = dt.Rows[i];
                    four.FId = int.Parse(row["FId"].ToString());
                    four.Fnom = row["Fnom"].ToString();
                    four.Fadd = row["Fadd"].ToString();
                    four.Fcontact = row["Fcontact"].ToString();
                    fours.Add(four);
                }
                return fours[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

    }


}
