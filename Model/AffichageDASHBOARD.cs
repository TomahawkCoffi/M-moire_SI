using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Mémoire_SI.Model
{
    internal class AffichageDASHBOARD
    {
        private SqlConnection con = DbConfig.con;

        public string Total_de_medicament()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(MedId) FROM med_tbl", con);
                int count = (int)cmd.ExecuteScalar();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                AffichageDASHBOARD affichage = new AffichageDASHBOARD();


                con.Close();

                return count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

        public string Total_de_catégorie()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(CId) FROM category", con);
                int count = (int)cmd.ExecuteScalar();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                AffichageDASHBOARD affichage = new AffichageDASHBOARD();


                con.Close();

                return count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

        public string Total_de_fournisseur()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(FId) FROM fournisseurs_tbl", con);
                int count = (int)cmd.ExecuteScalar();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                AffichageDASHBOARD affichage = new AffichageDASHBOARD();


                con.Close();

                return count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }
    }
    
}
