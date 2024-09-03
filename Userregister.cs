using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace Mémoire_SI
{
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\willc\Documents\si_db.mdf;Integrated Security=True;Connect Timeout=30");

        //private void CreerCompte(object sender, EventArgs e)


        private void checkbmdp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbmdp.Checked)
            {
                mdptxt.PasswordChar = '\0';
                commpdtxt.PasswordChar = '\0';

            }
            else
            {
                mdptxt.PasswordChar = '•';
                commpdtxt.PasswordChar = '•';

            }
        }

        private void mdptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            mdptxt.Text = "";
            commpdtxt.Text = "";
            usertxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Userlogin().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string username = usertxt.Text;
            string password = mdptxt.Text;
            string confirmpassword = commpdtxt.Text;
            string role = rolecombobox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpassword) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmpassword)
            {
                MessageBox.Show("La confirmation du mot de passe ne correspond pas au mot de passe saisi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con.Open();

                SqlCommand checkUsernameCommand = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE username=@username", con);
                {
                    checkUsernameCommand.Parameters.AddWithValue("@username", username);

                    int existingUserCount = (int)checkUsernameCommand.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Ce nom d'utilisateur existe déjà. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                SqlCommand insertUserCommand = new SqlCommand("INSERT INTO [User] (username,password,role) VALUES (@username, @password, @role); SELECT SCOPE_IDENTITY();", con);
                {
                    insertUserCommand.Parameters.AddWithValue("@username", username);
                    insertUserCommand.Parameters.AddWithValue("@password", password);
                    insertUserCommand.Parameters.AddWithValue("@role", role);

                    int userId = Convert.ToInt32(insertUserCommand.ExecuteScalar());

                    insertUserCommand.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Compte créé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création du compte : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmregister_Load(object sender, EventArgs e)
        {

        }
    }
}