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

namespace Mémoire_SI
{
    public partial class FournisseurList : Form
    {
        public FournisseurList()
        {
            InitializeComponent();
            Showfseur();
            Reset();

        }

        private int key;
        Fournisseur four = new Fournisseur();

        private void Showfseur()
        {
            FseurDGV.DataSource = four.Get();

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fseuraddbtn_Click(object sender, EventArgs e)
        {
            if (four.FId == 0)

                if (fseurnomtb.Text == "" || fseuraddtb.Text == "" || fseurnumtb.Text == "")
                {
                    MessageBox.Show("information manquante");
                }
                else
                {
                    try
                    {
                        four.Fnom = fseurnomtb.Text;
                        four.Fadd = fseuraddtb.Text;
                        four.Fcontact = fseurnumtb.Text;
                        four.Save(four);
                        Showfseur();
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
            fseurnomtb.Text = "";
            fseuraddtb.Text = "";
            fseurnumtb.Text = "";
            four = new Fournisseur();

        }
        private void Btnmod_Click(object sender, EventArgs e)
        {
            if (fseurnomtb.Text == "" || fseuraddtb.Text == "" || fseurnumtb.Text == "")
            {
                MessageBox.Show("information manquante");
                return;
            }
            else
            {
                try
                {

                    four.Fnom = fseurnomtb.Text;
                    four.Fadd = fseuraddtb.Text;
                    four.Fcontact = fseurnumtb.Text;

                    bool success = four.Update(four);
                    if (success)
                    {
                        Showfseur();
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
        private void Btnsupp_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Sélectionnez le fournisseur à supprimer");
            }
            else
            {
                try
                {
                    bool success = four.Delete(four);
                    if (success)
                    {
                        Showfseur();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Erreur");
                    }
                    Showfseur();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FseurDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(FseurDGV.SelectedRows[0].Cells[0].Value.ToString());

            four = four.FindOneById(key);

            fseurnomtb.Text = four.Fnom;
            fseuraddtb.Text = four.Fadd;
            fseurnumtb.Text = four.Fcontact;


        }
    }
}
