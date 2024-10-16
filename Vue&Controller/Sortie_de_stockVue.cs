using Mémoire_SI.Model;
using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
            // Vérification si les champs sont bien remplis
            if (string.IsNullOrEmpty(Nom_du_client.Text) || string.IsNullOrEmpty(Quantité.Text))
            {
                MessageBox.Show("Informations manquantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Arrêter l'exécution si des champs sont manquants
            }

            // Validation des autres champs
            try
            {
                sot.BNomclient = Nom_du_client.Text;

                if (Nom_du_medicament.SelectedValue != null)
                {
                    sot.BNommed = int.Parse(Nom_du_medicament.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un médicament.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Arrêter l'exécution si aucun médicament n'est sélectionné
                }

                sot.Bqte = int.Parse(Quantité.Text.ToString());

                // Validation de la date
                DateTime dateAchat;
                if (DateTime.TryParse(Date_achat.Text, out dateAchat))
                {
                    sot.Bdate = dateAchat;
                }
                else
                {
                    MessageBox.Show("Date invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Arrêter l'exécution si la date est invalide
                }

                // Vérification de la quantité disponible avant de sauvegarder
                if (sot.Bqte <= 0)
                {
                    MessageBox.Show("Quantité de stock invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Arrêter l'exécution si la quantité est invalide
                }

                // Si toutes les validations passent, enregistrer la sortie de stock
                bool saved = sot.Save(sot);

                if (saved)
                {
                    Showsortie();
                    // Générer le reçu PDF
                    GenerateReceipt(sot);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la sauvegarde de la sortie de stock", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (Nom_du_client.Text == "" || Quantité.Text == "")
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

                    DateTime dateAchat;
                    if (DateTime.TryParse(Date_achat.Text, out dateAchat))
                    {
                        sot.Bdate = dateAchat;
                    }
                    else
                    {
                        MessageBox.Show("Date d'achat invalide.");
                        return;
                    }


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
        private void Modifier_sortie_de_stock_Click(object sender, EventArgs e)
        {
            // Vérifiez que les champs contiennent des données avant de permettre la modification
            if (string.IsNullOrWhiteSpace(Nom_du_client.Text) || string.IsNullOrWhiteSpace(Quantité.Text))
            {
                MessageBox.Show("Veuillez renseigner les champs de modification avant de procéder.");
                return;
            }

            // Si les champs sont renseignés, on peut passer à la modification
            ModifierProduit();

            // Générer une nouvelle facture après modification
            GenererNouvelleFacture();
        }
        private void ModifierProduit()
        {
            if (Sortie_de_stockDGV.SelectedRows.Count > 0)
            {
                // Récupérer la ligne sélectionnée dans le tableau
                DataGridViewRow selectedRow = Sortie_de_stockDGV.SelectedRows[0];

                // Modifier les valeurs de la ligne sélectionnée avec les nouvelles données
                selectedRow.Cells["NomProduit"].Value = Nom_du_client.Text;
                selectedRow.Cells["Quantite"].Value = Quantité.Text;
                

                MessageBox.Show("Le produit a été modifié avec succès.");
            }
        }

        private void GenererNouvelleFacture()
        {
            // Logique pour générer une nouvelle facture
            MessageBox.Show("Nouvelle facture générée.");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Assurez-vous que les informations sont présentes
            if (string.IsNullOrWhiteSpace(Nom_du_client.Text) || string.IsNullOrWhiteSpace(Quantité.Text))
            {
                MessageBox.Show("Veuillez renseigner les champs de modification.");
                return;
            }

            // Modifier le produit
            ModifierProduit();

            // Générer une nouvelle facture après modification
            GenererNouvelleFacture();
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

            if (Sortie_de_stockDGV.SelectedRows.Count > 0)
            {
                var cellValue = Sortie_de_stockDGV.SelectedRows[0].Cells[0].Value;
                if (cellValue != null)
                {
                    key = Convert.ToInt32(cellValue.ToString());
                    sot = sot.FindOneById(key);
                    // ...
                }
                else
                {
                    MessageBox.Show("Sélectionnez une ligne valide.");
                }
            }


            Date_achat.Text = sot.Bdate.ToString();

            Nom_du_medicament.SelectedValue = sot.BNommed;

            Nom_du_client.Text = sot.BNomclient;

            Quantité.Text = sot.Bqte.ToString();
        }
        private void Sortie_de_stockDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (Sortie_de_stockDGV.SelectedRows.Count > 0)
            {
                // Désactiver le bouton "Ajouter" car un produit est sélectionné
                Ajouter_sortie_de_stock.Enabled = false;

                // Afficher un message pour inviter l'utilisateur à modifier au lieu d'ajouter
                MessageBox.Show("Un produit est sélectionné. Veuillez appuyer sur 'Modifier' pour mettre à jour le produit.");
            }
            else
            {
                // Si aucune ligne n'est sélectionnée, réactiver le bouton "Ajouter"
                Ajouter_sortie_de_stock.Enabled = true;
            }
        }

        private void dataGridView1DataGridView_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GenerateReceipt(Sortie_de_stock sot)
        {
            // Créer un document PDF
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Reçu Santé Intégrée";

            // Créer une page
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 16, XFontStyleEx.Regular);

            // Ajouter du texte sur le PDF
            gfx.DrawString("Reçu Santé Intégrée", new XFont("Arial", 22, XFontStyleEx.Bold), XBrushes.Black,
                new XRect(30, 40, page.Width, page.Height), XStringFormats.TopCenter);

            // Récupérer les informations directement depuis les champs de saisie
            string nomClient = Nom_du_client.Text; // Nom du client
            string nomMedicament = Nom_du_medicament.SelectedItem != null ? Nom_du_medicament.Text : "Inconnu"; // Nom du médicament
            string quantite = Quantité.Text; // Quantité
            string dateSortie = DateTime.Parse(Date_achat.Text).ToShortDateString(); // Date de sortie

            // Vérifier que toutes les informations sont présentes avant de générer le reçu
            if (string.IsNullOrEmpty(nomClient) || string.IsNullOrEmpty(quantite) || string.IsNullOrEmpty(dateSortie))
            {
                MessageBox.Show("Toutes les informations doivent être saisies pour générer un reçu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ajouter les informations sur le reçu PDF
            gfx.DrawString($"Nom du Client: {nomClient}", font, XBrushes.Black,
                new XRect(40, 100, page.Width, page.Height), XStringFormats.TopLeft);

            gfx.DrawString($"Nom du Médicament: {nomMedicament}", font, XBrushes.Black,
                new XRect(40, 130, page.Width, page.Height), XStringFormats.TopLeft);

            gfx.DrawString($"Quantité: {quantite}", font, XBrushes.Black,
                new XRect(40, 160, page.Width, page.Height), XStringFormats.TopLeft);

            gfx.DrawString($"Date de Sortie: {dateSortie}", font, XBrushes.Black,
                new XRect(40, 190, page.Width, page.Height), XStringFormats.TopLeft);

            gfx.DrawString($"Soyez toujours en bonne santé !", new XFont("Arial", 20, XFontStyleEx.Italic), XBrushes.Black,
                new XRect(0, 250, page.Width, page.Height), XStringFormats.TopCenter);

            // Sauvegarder le PDF dans un fichier
            string filename = $"Recu_{nomClient}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";
            document.Save(filename);

            // Ouvrir le fichier PDF après la génération
            MessageBox.Show($"Reçu généré avec succès : {filename}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(filename); // Ouvre le fichier PDF

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filename,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture du fichier PDF : {ex.Message}");
            }

        }

        private void Quantité_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
