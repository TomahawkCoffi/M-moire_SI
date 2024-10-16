using Mémoire_SI.Model;
using System;
using System.Data;
using System.Windows.Forms;


namespace Mémoire_SI
{
    public partial class FrmdashboardVue : Form
    {

        public FrmdashboardVue()
        {
            InitializeComponent();
            Total_de_medicament();
            Total_de_categorie();
            Total_de_fournisseur();
            Affichage_dates_entrees_sorties_stock();
        }

        AffichageDASHBOARD affichage = new AffichageDASHBOARD();
        private Entree_de_stock entreeStock = new Entree_de_stock();

        private void Total_de_medicament()
        {
            AffichageStock.Text = affichage.Total_de_medicament();
        }

        private void Total_de_categorie()
        {
            AffichageCategorie.Text = affichage.Total_de_catégorie();
        }

        private void Total_de_fournisseur()
        {
            Affichagefournisseurs.Text = affichage.Total_de_fournisseur();

        }

        private void Affichage_dates_entrees_sorties_stock()
        {
            try
            {
                var lastStockEntry = entreeStock.Get(); // Utiliser la méthode Get() pour obtenir les données d'entrée

                if (lastStockEntry != null)
                {
                    DataTable dt = (DataTable)lastStockEntry;

                    if (dt.Rows.Count > 0)
                    {
                        // Récupérer la dernière entrée
                        DataRow lastRow = dt.Rows[dt.Rows.Count - 1];
                        Affichagedateentreestock.Text = lastRow["DateLivraison"].ToString();
                        Affichagedatesortiestock.Text = lastRow["DatePeromption"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage des dates : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Get_stock_affichage_list()
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AffichageCategorie_Click(object sender, EventArgs e)
        {

        }

        private void Affichagefournisseurs_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Affichagedatesortiestock_Click(object sender, EventArgs e)
        {

        }
    }
}
