using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mémoire_SI.Model;
using Microsoft.Data.SqlClient;


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
        }

        AffichageDASHBOARD affichage = new AffichageDASHBOARD();

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
    }
}
