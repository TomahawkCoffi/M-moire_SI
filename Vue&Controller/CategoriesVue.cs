using Mémoire_SI.Model;
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
    public partial class CategoriesVue : Form
    {
        public CategoriesVue()
        {
            InitializeComponent();
            showcat();
            Reset();

        }

        private int key;
        Categorie cat = new Categorie();


        private void showcat()
        {
            categorieDGV.DataSource = cat.Get();
        }

        private void cataddbtn_Click(object sender, EventArgs e)
        {
            if (cat.CId == 0)
            {
                if (catnomtb.Text == "")
                {
                    MessageBox.Show("Entrez un nom pour la catégorie");
                    return;
                }
                else
                {
                    cat.Catnom = catnomtb.Text;
                    cat.Save(cat);
                    showcat();
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Veuillez appuyer sur modifier!");
            }
        }

        private void btncatmod_Click(object sender, EventArgs e)
        {
            {
                if (catnomtb.Text == "")
                {
                    MessageBox.Show("Entrez un nom pour la catégorie");
                    return;
                }
                else
                {
                    cat.Catnom = catnomtb.Text;
                   bool success = cat.Update(cat);
                    if (success)
                    {
                        showcat();
                        Reset();

                    } else
                    {
                        MessageBox.Show("Rééssayer");
                    }
                }
            }
        
    }

        private void btncatsupp_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Sélectionnez la catégorie à supprimer");
            }
            else
            {
                try
                {
                    bool success = cat.Delete(cat);
                    if (success)
                    {
                        showcat();
                        Reset();
                    } 
                    else 
                    {
                        MessageBox.Show("Erreur, la categorie n'a pu etre supprime");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset()
        {
            catnomtb.Text = "";
            cat = new Categorie();
        }

        private void categorieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(categorieDGV.SelectedRows[0].Cells[0].Value.ToString());
           
            cat = cat.FindOneById(key);

            catnomtb.Text = cat.Catnom;
        }

    }
}
