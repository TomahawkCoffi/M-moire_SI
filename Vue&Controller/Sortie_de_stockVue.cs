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
    public partial class Sortie_de_stockVue : Form
    {
        public Sortie_de_stockVue()
        {
            InitializeComponent();
            Medicamentsdropdown();
            Showsortie();
            Reset();
        }

        private int key;
        Sortie_de_stock sot = new Sortie_de_stock();

        private void Medicamentsdropdown()
        {

            Medicament med = new Medicament();
            med.Medicamentsdropdown(Nom_du_medicament);

        }
        private void Showsortie()
        {
            Sortie_de_stockDGV.DataSource = sot.Get();
        }

        private void Sortie_de_stock_add_btn_Click(object sender, EventArgs e)
        {
            if (sot.BId == 0)

                if (Quantité.Text == "")
                {
                    MessageBox.Show("information manquante");
                }
                else
                {

                    try
                    {
                        sot.BNomclient = Nom_du_client.Text;
                        sot.BNommed = int.Parse(Nom_du_medicament.SelectedValue.ToString());
                        sot.Bqte = int.Parse(Quantité.Text.ToString());
                        sot.Bdate = DateTime.Parse(Date_achat.Text.ToString());


                        sot.Save(sot);
                        Showsortie();
                        Reset();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            else
            {
                MessageBox.Show("Appuyer sur modifier ");
            }
        }

        private void Reset()
        {
            Nom_du_client.Text = "";
            Quantité.Text = "";
            sot = new Sortie_de_stock();
        }

        private void Sortie_de_stock_mednomcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sortie_de_stock_modif_btn_Click(object sender, EventArgs e)
        {
            if (Nom_du_client.Text == ""|| Quantité.Text == "")
            {
                MessageBox.Show("information manquante");
                return;
            }
            else
            {
                try
                {

                    sot.BNomclient = Nom_du_client.Text;
                    sot.BNommed = int.Parse(Nom_du_medicament.SelectedValue.ToString());
                    sot.Bqte = int.Parse(Quantité.Text.ToString());
                    sot.Bdate = DateTime.Parse(Date_achat.Text.ToString());

                    bool success = sot.Update(sot);
                    if (success)
                    {
                        Showsortie();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Rééssayer");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Sortie_de_stock_supp_btn_Click(object sender, EventArgs e)
        {
            {
                if (key == 0)
                {
                    MessageBox.Show("Sélectionnez une sortie de stock");
                }
                else
                {
                    try
                    {
                        bool success = sot.Delete(sot);
                        if (success)
                        {
                            Showsortie();
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Erreur");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Sortie_de_stockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(Sortie_de_stockDGV.SelectedRows[0].Cells[0].Value.ToString());


            sot = sot.FindOneById(key);


            Date_achat.Text = sot.Bdate.ToString();

            Nom_du_medicament.SelectedValue = sot.BNommed;

            Nom_du_client.Text = sot.BNomclient;

            Quantité.Text = sot.Bqte.ToString();
        }

        private void dataGridView1DataGridView_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
