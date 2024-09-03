using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Mémoire_SI
{
    public partial class SituationVue : Form
    {
        public SituationVue()
        {
            InitializeComponent();
            ShowGrandStock();
        }

        //private int key;
        Situation sit = new Situation();

        private void ShowGrandStock()
        {
            DataGridView_stock.DataSource = sit.Get_stock_affichage_list();
        }
        private void stockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
