using Mémoire_SI.Model;
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
using System.Windows.Input;


namespace Mémoire_SI
{
    public partial class MedicamentList : Form
    {
        public MedicamentList()
        {
            InitializeComponent();
            Showmed();
            Reset();
            Categorydropdown();
        }

        private int key;
        Medicament med = new Medicament();

        private void Categorydropdown()
        {
            Categorie cat = new Categorie();
            cat.categorydropdown(medcatcb);

        }
        private void Showmed()
        {
            medicamentDGV.DataSource = med.Get();
        }

        private void medicament_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'si_dbDataSet1.category'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categoryTableAdapter.Fill(this.si_dbDataSet1.category);

        }

        private void medcatcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void medaddbtn_Click(object sender, EventArgs e)
        {
            if (med.MedId == 0)

                if (mednomtb.Text == "")
                {
                    MessageBox.Show("Entrer le nom du médicament");
                }
                else
                {

                    try
                    {
                        med.Mednom = mednomtb.Text;
                        med.Medcat = int.Parse(medcatcb.SelectedValue.ToString());

                        med.Save(med);
                        Showmed();
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
            mednomtb.Text = "";
            med = new Medicament();

        }
        private void btnmedmod_Click(object sender, EventArgs e)
        {
            if (mednomtb.Text == "")
            {
                MessageBox.Show("information manquante");
                return;
            }
            else
            {
                try
                {

                    med.Mednom = mednomtb.Text;
                    med.Medcat = int.Parse(medcatcb.SelectedValue.ToString());

                    bool success = med.Update(med);
                    if (success)
                    {
                        Showmed();
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


        private void medicamentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            key = Convert.ToInt32(medicamentDGV.SelectedRows[0].Cells[0].Value.ToString());
            med = med.FindOneById(key);

            mednomtb.Text = med.Mednom;
            medcatcb.SelectedValue = med.Medcat;



            med.Mednom = mednomtb.Text;



            //medcatcb.SelectedItem = new Medicaments() { Mednom = med.Mednom, MedId = med.MedId };

        }

        private void medcatcb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnmedsupp_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Sélectionnez le médicament à supprimer");
            }
            else
            {
                try
                {
                    bool success = med.Delete(med);
                    if (success)
                    {
                        Showmed();
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
}
