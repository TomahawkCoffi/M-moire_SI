using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K4os.Compression.LZ4.Internal;
using Mémoire_SI.Model;
using Microsoft.Data.SqlClient;
using System.Windows.Input;
using System.Security.Policy;



namespace Mémoire_SI
{
    public partial class Entree_de_stocksVue : Form
    {
        public Entree_de_stocksVue()
        {
            InitializeComponent();
            Showliv();
            Medicamentsdropdown();
        }

        private int key;
        Entree_de_stock ent = new Entree_de_stock();


        private void Medicamentsdropdown()
        {

            Medicament med = new Medicament();
            med.Medicamentsdropdown(entree_de_stock_mednomcb);

        }
        private void Showliv()
        {
            Entree_de_stockDGV.DataSource = ent.Get();

        }


        private void Livraison_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'si_dbDataSet3.fournisseurs_tbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseurs_tblTableAdapter.Fill(this.si_dbDataSet3.fournisseurs_tbl);
            // TODO: cette ligne de code charge les données dans la table 'si_dbDataSet2.med_tbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.med_tblTableAdapter.Fill(this.si_dbDataSet2.med_tbl);

        }

        private void Medfseurcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Medaddbtn_Click_1(object sender, EventArgs e)
        {
            if (ent.LId == 0)

                if (entree_de_stock_qte.Text == "")
                {
                    MessageBox.Show("information manquante");
                }
                else
                {

                    try
                    {
                        ent.Lmednom = int.Parse(entree_de_stock_mednomcb.SelectedValue.ToString());
                        ent.Lfnom = int.Parse(entree_de_stock_fseurnomcb.SelectedValue.ToString());
                        ent.Lqte = int.Parse(entree_de_stock_qte.Text.ToString());
                        ent.Ldateliv = DateTime.Parse(medlivdate.Text.ToString());
                        ent.Ldateper = DateTime.Parse(medvaldate.Text.ToString());


                        ent.Save(ent);
                        Showliv();
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
            entree_de_stock_qte.Text = "";
            ent = new Entree_de_stock();
        }


        private void Entree_de_stock_modif_btn_Click(object sender, EventArgs e)
        {
            if (entree_de_stock_qte.Text == "")
            {
                MessageBox.Show("information manquante");
                return;
            }
            else
            {
                try
                {

                    ent.Lmednom = int.Parse(entree_de_stock_mednomcb.SelectedValue.ToString());
                    ent.Lfnom = int.Parse(entree_de_stock_fseurnomcb.SelectedValue.ToString());
                    ent.Lqte = int.Parse(entree_de_stock_qte.Text.ToString());
                    ent.Ldateliv = DateTime.Parse(medlivdate.Text.ToString());
                    ent.Ldateper = DateTime.Parse(medvaldate.Text.ToString());

                    bool success = ent.Update(ent);
                    if (success)
                    {
                        Showliv ();
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


        private void Entree_de_stock_supp_btn_Click(object sender, EventArgs e)
        {
            {
                if (key == 0)
                {
                    MessageBox.Show("Sélectionnez une entrée de stock");
                }
                else
                {
                    try
                    {
                        bool success = ent.Delete(ent);
                        if (success)
                        {
                            Showliv();
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

        private void Entree_de_stockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(Entree_de_stockDGV.SelectedRows[0].Cells[0].Value.ToString());


            ent = ent.FindOneById(key);

       
            medvaldate.Text = ent.Ldateper.ToString();
            medlivdate.Text = ent.Ldateliv.ToString();
            entree_de_stock_mednomcb.SelectedValue = ent.Lmednom;
            entree_de_stock_qte.Text = ent.Lqte.ToString();
            entree_de_stock_fseurnomcb.SelectedValue = ent.Lfnom;


            //medvaldate.Text = ent.Ldateper.;
        }


    }
}
