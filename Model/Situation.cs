using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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

        public DataTable Get_stock_affichage_list()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT med_tbl.Mednom as Medicament, fournisseurs_tbl.Fnom as Fournisseur, SUM(livraison.Lqte) as TotalStock, livraison.Ldateliv as DateLivraison, livraison.Ldateper as DatePeremption FROM livraison JOIN med_tbl ON livraison.Lmednom = med_tbl.MedId JOIN fournisseurs_tbl ON livraison.Lfnom = fournisseurs_tbl.FId GROUP BY med_tbl.Mednom, fournisseurs_tbl.Fnom, livraison.Ldateliv, livraison.Ldateper", con))
                {
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        con.Open();
                        adap.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            return dt;
        }

        // Méthode pour ajouter le tableau de données dans une DataGridView avec mise en surbrillance rouge
        public void AfficherStock(DataGridView dataGridView)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT med_tbl.Mednom AS Medicament, fournisseurs_tbl.Fnom AS Fournisseur, SUM(livraison.Lqte) AS TotalStock, livraison.Ldateliv AS DateLivraison, livraison.Ldateper AS DatePeremption FROM livraison JOIN med_tbl ON livraison.Lmednom = med_tbl.MedId JOIN fournisseurs_tbl ON livraison.Lfnom = fournisseurs_tbl.FId GROUP BY med_tbl.Mednom, fournisseurs_tbl.Fnom, livraison.Ldateliv, livraison.Ldateper", con);
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                con.Close();

                dataGridView.DataSource = dt;

                // Appliquer la surbrillance aux lignes où le stock est inférieur à 50
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells["TotalStock"].Value != null && int.TryParse(row.Cells["TotalStock"].Value.ToString(), out int stock))
                    {
                        if (stock < 50)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White; // Pour une meilleure visibilité du texte
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage du stock : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
