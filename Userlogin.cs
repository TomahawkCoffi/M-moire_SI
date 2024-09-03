using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace Mémoire_SI
{
    public partial class Userlogin : Form
    {
        public Userlogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\willc\Documents\si_db.mdf;Integrated Security=True;Connect Timeout=30");

        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter da = new SqlDataAdapter();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string password = mdptxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez saisir le nom d'utilisateur et le mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                {
                    con.Open();

                    
                    SqlCommand checkUserCommand = new SqlCommand("SELECT Id, username, password, role FROM [User] WHERE username=@username",con);
                    {
                        checkUserCommand.Parameters.AddWithValue("@username", username);

                        SqlDataReader reader = checkUserCommand.ExecuteReader();
                        {
                            if (reader.Read())
                            {
                                if (reader.Read())
                                {
                                    int loggedInUserId = Convert.ToInt32(reader["Id"]);
                                    string Role = reader["role"].ToString();

                                    MessageBox.Show($"Connexion réussie en tant que {username} avec le rôle {Role}.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    new Tableau_de_bordVue().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Utilisateur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            mdptxt.Text = "";
            usertxt.Focus();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkboxmdp.Checked)
            {
                mdptxt.PasswordChar = '\0';

            }
            else
            {
                mdptxt.PasswordChar = '•';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmregister().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Userlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
