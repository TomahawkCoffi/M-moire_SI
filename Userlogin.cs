using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


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

        //// Méthode pour hasher le mot de passe (même que dans l'enregistrement)
        //public static string HashPassword(string password)
        //{
        //    using (SHA256 sha256Hash = SHA256.Create())
        //    {
        //        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder builder = new StringBuilder();
        //        for (int i = 0; i < bytes.Length; i++)
        //        {
        //            builder.Append(bytes[i].ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }
        //}

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
                con.Open();

                SqlCommand checkUserCommand = new SqlCommand("SELECT Id, username, password, role FROM [User] WHERE username=@username", con);
                checkUserCommand.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = checkUserCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Vérification du mot de passe 
                    if (reader["password"].ToString() == password)
                    {
                        int loggedInUserId = Convert.ToInt32(reader["Id"]);
                        string Role = reader["role"].ToString();
                        string Username = reader["username"].ToString(); // Récupération du nom d'utilisateur

                        MessageBox.Show($"Connexion réussie en tant que {username} avec le rôle {Role}.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Passez le nom d'utilisateur au tableau de bord
                        //Tableau_de_bordVue dashboard = new Tableau_de_bordVue();
                        Tableau_de_bordVue dashboard = new Tableau_de_bordVue(loggedInUserId, Role);
                        dashboard.Show();

                        dashboard.SetUsername(Username); // Appelle une méthode pour définir le nom d'utilisateur
                        dashboard.ActiverDesactiverBoutons(Role); // Appelle la méthode pour activer/désactiver les boutons
                        dashboard.Show();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
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
        private void label2_Click(object sender, EventArgs e)
        {
            
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
