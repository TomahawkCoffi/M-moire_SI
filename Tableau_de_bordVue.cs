using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Relational;


namespace Mémoire_SI
{
    public partial class Tableau_de_bordVue : Form
    {
        private int loggedInUserId;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );


        public Tableau_de_bordVue()
        {
            InitializeComponent();
            //this.loggedInUserId = userId;
            ShowUsernameOnHomePage();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlnav.Height = btndshb.Height;
            pnlnav.Top = btndshb.Top;
            pnlnav.Left = btndshb.Left;
            btndshb.BackColor = Color.Turquoise;

            lbltitre.Text = "DASHBOARD";
            this.pnlformloader.Controls.Clear();
            FrmdashboardVue Frmdashboard_Vrb = new FrmdashboardVue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();

            
        }

        /*public class ShowCurrentUser
        {
            private int loggedInUserId;
            // ... Autres membres de la classe ...
        }*/



        private void button4_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btndeco.Height;
            pnlnav.Top = btndeco.Top;
            btndeco.BackColor = Color.Turquoise;

            new Userlogin().Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btndshb_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btndshb.Height;
            pnlnav.Top = btndshb.Top;
            pnlnav.Left = btndshb.Left;
            btndshb.BackColor = Color.Turquoise;

            lbltitre.Text = "DASHBOARD";
            this.pnlformloader.Controls.Clear();
            FrmdashboardVue Frmdashboard_Vrb = new FrmdashboardVue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnstock.Height;
            pnlnav.Top = btnstock.Top;
            btnstock.BackColor = Color.Turquoise;

            lbltitre.Text = "STOCK";
            this.pnlformloader.Controls.Clear();
            SituationVue Frmdashboard_Vrb = new SituationVue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btnhstr_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnhstr.Height;
            pnlnav.Top = btnhstr.Top;
            btnhstr.BackColor = Color.Turquoise;

            lbltitre.Text = "HISTORIQUE";
            this.pnlformloader.Controls.Clear();
            Historique Frmdashboard_Vrb = new Historique() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btncase_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnsortistk.Height;
            pnlnav.Top = btnsortistk.Top;
            btnsortistk.BackColor = Color.Turquoise;

            lbltitre.Text = "SORTIE DE STOCK";
            this.pnlformloader.Controls.Clear();
            Sortie_de_stockVue Frmdashboard_Vrb = new Sortie_de_stockVue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btndshb_Leave(object sender, EventArgs e)
        {
            btndshb.BackColor = Color.Transparent;
        }

        private void btnstock_Leave(object sender, EventArgs e)
        {
            btnstock.BackColor = Color.Transparent;
        }

        private void btnhstr_Leave(object sender, EventArgs e)
        {
            btnhstr.BackColor = Color.Transparent;
        }

        private void btncase_Leave(object sender, EventArgs e)
        {
            btnsortistk.BackColor = Color.Transparent;
        }

        private void btndeco_Leave(object sender, EventArgs e)
        {
            btndeco.BackColor = Color.Transparent;
        }

        private void txtboxRer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btncmd.Height;
            pnlnav.Top = btncmd.Top;
            btncmd.BackColor = Color.Turquoise;

            lbltitre.Text = "COMMANDE";
            this.pnlformloader.Controls.Clear();
            Commande_livraison Frmdashboard_Vrb = new Commande_livraison() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pnlnav.Height = btnentreestk.Height;
            pnlnav.Top = btnentreestk.Top;
            btnentreestk.BackColor = Color.Turquoise;

            lbltitre.Text = "ENTREE DE STOCK";
            this.pnlformloader.Controls.Clear();
            Entree_de_stocksVue Frmdashboard_Vrb = new Entree_de_stocksVue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnfsr.Height;
            pnlnav.Top = btnfsr.Top;
            btnfsr.BackColor = Color.Turquoise;

            lbltitre.Text = "FOURNISSEURS";
            this.pnlformloader.Controls.Clear();
            FournisseurList Frmdashboard_Vrb = new FournisseurList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btndeco_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btndeco.Height;
            pnlnav.Top = btndeco.Top;
            btndeco.BackColor = Color.Red;

            new Userlogin().Show();
            this.Hide();
        }

        private void btncmd_liv_Leave(object sender, EventArgs e)
        {
            btncmd.BackColor = Color.Transparent;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            btnentreestk.BackColor = Color.Transparent;
        }

        private void btnfsr_Leave(object sender, EventArgs e)
        {
            btnfsr.BackColor = Color.Transparent;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            pnlnav.Height = btncat.Height;
            pnlnav.Top = btncat.Top;
            btncat.BackColor = Color.Turquoise;

            lbltitre.Text = "CATEGORIE";
            this.pnlformloader.Controls.Clear();
            CategoriesVue Frmdashboard_Vrb = new CategoriesVue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btncat_Leave(object sender, EventArgs e)
        {
            btncat.BackColor = Color.Transparent;

        }

        private void btnmed_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnmed.Height;
            pnlnav.Top = btnmed.Top;
            btnmed.BackColor = Color.Turquoise;

            lbltitre.Text = "MEDICAMENT";
            this.pnlformloader.Controls.Clear();
            MedicamentList Frmdashboard_Vrb = new MedicamentList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btnmed_Leave(object sender, EventArgs e)
        {
            btnmed.BackColor = Color.Transparent;

        }

        private void pnlformloader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_user_Click(object sender, EventArgs e)
        {
            ShowUsernameOnHomePage();
        }

        private void ShowUsernameOnHomePage()
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\willc\Documents\si_db.mdf;Integrated Security=True;Connect Timeout=30");

                {
                    con.Open();

                    // Récupère le nom de l'utilisateur à partir de l'ID stocké
                    SqlCommand getUserCommand = new SqlCommand("SELECT username FROM [User] WHERE Id=@userId", con);
                    {
                        getUserCommand.Parameters.AddWithValue("@userId", loggedInUserId);

                        object result = getUserCommand.ExecuteScalar();

                        string username = label_user.Text;




                        if (result != null)
                        {
                            string userRole = result.ToString();
                            label_user.Text = $"Bienvenue, {username}!";

                            // Désactive tous les boutons par défaut
                            btndshb.Enabled = false;
                            btnstock.Enabled = false;
                            btnhstr.Enabled = false;
                            //btncase.Enabled = false;
                            btncmd.Enabled = false;
                            btnentreestk.Enabled = false;
                            btnfsr.Enabled = false;
                            btncat.Enabled = false;
                            btnmed.Enabled = false;

                            // Active le bouton de Sortie de stock si l'utilisateur a le rôle "User"
                            if (userRole == "User")
                            {
                                btnsortistk.Enabled = true;
                            }
                            // Active tous les boutons si l'utilisateur a le rôle "Admin"
                            else if (userRole == "Admin")
                            {
                                btndshb.Enabled = true;
                                btnstock.Enabled = true;
                                btnhstr.Enabled = true;
                                //btncase.Enabled = true;
                                btncmd.Enabled = true;
                                btnentreestk.Enabled = true;
                                btnfsr.Enabled = true;
                                btncat.Enabled = true;
                                btnmed.Enabled = true;
                            }

                            /* if (result != null)
                             {
                                 string username = result.ToString();
                                 label_user.Text = $"Bienvenue, {username}!";
                             }*/
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du nom de l'utilisateur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
