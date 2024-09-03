using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mémoire_SI.Model;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Mémoire_SI
{
    internal class Sortie_de_stock
    {
        public int BId { get; set; }

        public int BNommed { get; set; }

        public string BNomclient { get; set; }

        public int Bqte { get; set; }

        public DateTime Bdate { get; set; }



        private SqlConnection con = DbConfig.con;


        public bool Save(Sortie_de_stock sot)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO facture (BNomclient,Bqte,Bdate,BNommed)values(@BN,@BQ,@BD,@BNM)", con);
                cmd.Parameters.AddWithValue("@BN", sot.BNomclient);
                cmd.Parameters.AddWithValue("@BQ", sot.Bqte);
                cmd.Parameters.AddWithValue("@BD", sot.Bdate);
                cmd.Parameters.AddWithValue("@BNM", sot.BNommed);


                cmd.ExecuteNonQuery();
                MessageBox.Show("sortie de stock enregistrée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }
        public bool Update(Sortie_de_stock sot)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE facture SET BNomclient=@BN,Bqte=@BQ,Bdate=@BD,BNommed=@BNM WHERE BId=@Bkey", con);
                cmd.Parameters.AddWithValue("@BN", sot.BNomclient);
                cmd.Parameters.AddWithValue("@BQ", sot.Bqte);
                cmd.Parameters.AddWithValue("@BD", sot.Bdate);
                cmd.Parameters.AddWithValue("@BNM", sot.BNommed);
                cmd.Parameters.AddWithValue("@Bkey", sot.BId);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Information modifiée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }
        public bool Delete(Sortie_de_stock sot)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM facture WHERE BId=@Bkey", con);
                cmd.Parameters.AddWithValue("@Bkey", sot.BId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("sortie de stock supprimée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public List<Sortie_de_stock> Get()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * from facture", con);
                adap.Fill(dt);
                con.Close();
                List<Sortie_de_stock> sots = new List<Sortie_de_stock>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Sortie_de_stock sot = new Sortie_de_stock();
                    var row = dt.Rows[i];
                    sot.BId = int.Parse(row["BId"].ToString());
                    sot.BNommed = int.Parse(row["BNommed"].ToString());
                    sot.BNomclient = row["BNomclient"].ToString();
                    sot.Bqte = int.Parse(row["Bqte"].ToString());
                    sot.Bdate = DateTime.Parse(row["Bdate"].ToString());

                    sots.Add(sot);
                }
                return sots;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }

        }

        public Sortie_de_stock FindOneById(int key)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter($"SELECT * from facture WHERE BId={key}", con);
                adap.Fill(dt);
                con.Close();
                List<Sortie_de_stock> sots = new List<Sortie_de_stock>();

                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Sortie_de_stock sot = new Sortie_de_stock();
                    var row = dt.Rows[i];
                    sot.BId = int.Parse(row["BId"].ToString());
                    sot.BNommed = int.Parse(row["BNommed"].ToString());
                    sot.BNomclient = row["BNomclient"].ToString();
                    sot.Bqte = int.Parse(row["Bqte"].ToString());
                    sot.Bdate = DateTime.Parse(row["Bdate"].ToString());

                    sots.Add(sot);

                }
                return sots[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }
    }
}
