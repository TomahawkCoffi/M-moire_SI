using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mémoire_SI
{
    public partial class SituationVue : Form
    {
        public SituationVue()
        {
            InitializeComponent();
            ShowGrandStock();
        }

        Situation sit = new Situation();

        private void ShowGrandStock()
        {
            // Utilisation de la méthode AfficherStock pour l'affichage et la mise en surbrillance des stocks
            sit.AfficherStock(DataGridView_stock);
        }

        private void stockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code pour gérer les événements de clic dans le DataGridView si nécessaire
        }

        private void DataGridView_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code pour gérer les événements de clic dans le DataGridView si nécessaire
        }
    }
}
