using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Mémoire_SI
{
    internal class Situation
    {

        public int LId { get; set; }

        public string Nom_du_medicament { get; set; }

        public string Nom_de_la_categorie { get; set; }

        public string Nom_du_fournisseur { get; set; }

        public int Quantité_disponible { get; set; }

        public DateTime Date_entree_en_stock { get; set; }

        public DateTime Date_de_peremeption { get; set; }


        private SqlConnection con = DbConfig.con;

        public object Get_stock_affichage_list() 
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand ("SELECT med_tbl.Mednom as Medicament,fournisseurs_tbl.Fnom as Fournisseur, SUM(livraison.Lqte) as TotalStock,livraison.Ldateliv as DateLivraison,livraison.Ldateper as DatePeremption FROM livraison JOIN med_tbl ON livraison.Lmednom=med_tbl.MedId JOIN fournisseurs_tbl ON livraison.Lfnom=fournisseurs_tbl.FId GROUP BY med_tbl.Mednom,fournisseurs_tbl.Fnom,livraison.Ldateliv,livraison.Ldateper", con);
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                con.Close();
                
                    List<Situation> sits = new List<Situation>();
                   /* for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                    {
                        var row = dt.Rows[i];
                        Situation sit = new Situation();
                        sit.LId = i + 1;
                        //sit.LId = int.Parse(dt.Rows[i]["LId"].ToString());
                        sits.Add(sit);
                    }*/
                    return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
                        
        }

    }
}
