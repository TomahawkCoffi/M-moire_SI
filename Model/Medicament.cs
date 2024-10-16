using Mémoire_SI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mémoire_SI
{
    internal class Medicament
    {
        public int MedId { get; set; }

        public string Mednom { get; set; }

        public int Medcat { get; set; }

        private SqlConnection con = DbConfig.con;

        public bool Save(Medicament med)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO med_tbl(Mednom,Medcat)values(@MN,@MCAT)", con);
                cmd.Parameters.AddWithValue("@MN", med.Mednom);
                cmd.Parameters.AddWithValue("@MCAT", med.Medcat);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Médicament ajouté");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public bool Update(Medicament med)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE med_tbl SET Mednom=@MN,Medcat=@MCAT WHERE MedId=@Mkey", con);
                cmd.Parameters.AddWithValue("@MN", med.Mednom);
                cmd.Parameters.AddWithValue("@MCAT", med.Medcat);
                cmd.Parameters.AddWithValue("@Mkey", med.MedId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Information du médicament modifiée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public bool Delete(Medicament med)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM med_tbl WHERE MedId=@Mkey", con);
                cmd.Parameters.AddWithValue("@Mkey", med.MedId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Médicament supprimé");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public List<Medicament> Get()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * from med_tbl", con);
                adap.Fill(dt);
                con.Close();
                List<Medicament> meds = new List<Medicament>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Medicament med = new Medicament();
                    var row = dt.Rows[i];
                    med.MedId = int.Parse(row["MedId"].ToString());
                    med.Mednom = row["Mednom"].ToString();
                    med.Medcat = int.Parse(row["Medcat"].ToString());
                    meds.Add(med);
                }
                return meds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

        public Medicament FindOneById(int key)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter($"SELECT * from med_tbl WHERE MedId={key}", con);
                adap.Fill(dt);
                con.Close();
                List<Medicament> meds = new List<Medicament>();

                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Medicament med = new Medicament();
                    var row = dt.Rows[i];
                    med.MedId = int.Parse(row["MedId"].ToString());
                    med.Mednom = row["Mednom"].ToString();
                    med.Medcat = int.Parse(row["Medcat"].ToString());
                    meds.Add(med);
                }
                return meds[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

        public void Medicamentsdropdown(Guna.UI2.WinForms.Guna2ComboBox entree_de_stock_mednomcb)
        {
            List<Medicament> meds = new List<Medicament>();

            foreach (Medicament med in this.Get())
            {
                meds.Add(new Medicament() { Mednom = med.Mednom, MedId = med.MedId });
            }
            entree_de_stock_mednomcb.DataSource = meds;
            entree_de_stock_mednomcb.DisplayMember = "Mednom";
            entree_de_stock_mednomcb.ValueMember = "MedId";

        }

        /* public List<Situation> Get_stock_affichage_list() 
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand ("SELECT Lmednom, SUM(Lqte) AS TOTALSTOCK FROM livraison GROUP BY Lmednom", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                List<Situation> sits = new List<Situation>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Situation sit = new Situation();
                    sit.LId = i + 1;
                    sit.LId = int.Parse(dt.Rows[i]["LId"].ToString());
                    sits.Add(sit);

                }
                con.Close();

                return sits;
            }
            catch (Exception ex)
            {

            }
            return null;
            
            
        }*/
    }

}
