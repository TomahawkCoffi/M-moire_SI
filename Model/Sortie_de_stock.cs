using Mémoire_SI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Mémoire_SI
{
    internal class Sortie_de_stock
    {
        public int BId { get; set; }
        public int BNommed { get; set; }
        public string BNomclient { get; set; }
        public int Bqte { get; set; }
        public DateTime Bdate { get; set; }

        private SqlConnection con = DbConfig.con;

        public bool Save(Sortie_de_stock sot)
        {
            // Vérifier la date avant de procéder
            if (!ValidateDate(sot.Bdate))
            {
                MessageBox.Show("La date de sortie de stock ne peut pas être antérieure à la date du jour.", "Erreur de validation de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                con.Open();

                // Vérifier la quantité disponible dans la table livraison
                SqlCommand checkCmd = new SqlCommand("SELECT ISNULL(Lqte, 0) FROM livraison WHERE Lmednom = @MedId", con);
                checkCmd.Parameters.AddWithValue("@MedId", sot.BNommed);

                object result = checkCmd.ExecuteScalar();
                int stockDisponible = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                if (stockDisponible < sot.Bqte)
                {
                    MessageBox.Show($"Rupture de stock : Quantité disponible de {stockDisponible} inférieure à la quantité demandée de {sot.Bqte}.", "Erreur de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return false;
                }

                SqlCommand updateCmd = new SqlCommand("UPDATE livraison SET Lqte = Lqte - @QuantitéSortie WHERE Lmednom = @MedId", con);
                updateCmd.Parameters.AddWithValue("@QuantitéSortie", sot.Bqte);
                updateCmd.Parameters.AddWithValue("@MedId", sot.BNommed);
                updateCmd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("INSERT INTO facture (BNomclient, Bqte, Bdate, BNommed) VALUES (@BN, @BQ, @BD, @BNM)", con);
                cmd.Parameters.AddWithValue("@BN", sot.BNomclient);
                cmd.Parameters.AddWithValue("@BQ", sot.Bqte);
                cmd.Parameters.AddWithValue("@BD", sot.Bdate);
                cmd.Parameters.AddWithValue("@BNM", sot.BNommed);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sortie de stock enregistrée avec succès.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private bool ValidateDate(DateTime date)
        {
            // Validation pour empêcher une date antérieure à la date actuelle
            if (date < DateTime.Now.Date) // Comparaison avec la date actuelle
            {
                return false;
            }
            return true;
        }

        public bool Update(Sortie_de_stock sot)
        {
            // Vérifier la date avant de procéder
            if (!ValidateDate(sot.Bdate))
            {
                MessageBox.Show("La date de modification ne peut pas être antérieure à la date du jour.", "Erreur de validation de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE facture SET BNomclient=@BN, Bqte=@BQ, Bdate=@BD, BNommed=@BNM WHERE BId=@Bkey", con);
                cmd.Parameters.AddWithValue("@BN", sot.BNomclient);
                cmd.Parameters.AddWithValue("@BQ", sot.Bqte);
                cmd.Parameters.AddWithValue("@BD", sot.Bdate);
                cmd.Parameters.AddWithValue("@BNM", sot.BNommed);
                cmd.Parameters.AddWithValue("@Bkey", sot.BId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Information modifiée");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Delete(Sortie_de_stock sot)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM facture WHERE BId=@Bkey", con);
                cmd.Parameters.AddWithValue("@Bkey", sot.BId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sortie de stock supprimée");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Sortie_de_stock> Get()
        {
            List<Sortie_de_stock> sots = new List<Sortie_de_stock>();

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * from facture", con);
                adap.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Sortie_de_stock sot = new Sortie_de_stock();
                    var row = dt.Rows[i];
                    sot.BId = Convert.ToInt32(row["BId"]);
                    sot.BNommed = Convert.ToInt32(row["BNommed"]);
                    sot.BNomclient = row["BNomclient"].ToString();
                    sot.Bqte = Convert.ToInt32(row["Bqte"]);
                    sot.Bdate = Convert.ToDateTime(row["Bdate"]);

                    sots.Add(sot);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                con.Close();
            }

            return sots;
        }

        public Sortie_de_stock FindOneById(int key)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter($"SELECT * from facture WHERE BId={key}", con);
                adap.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    Sortie_de_stock sot = new Sortie_de_stock
                    {
                        BId = Convert.ToInt32(row["BId"]),
                        BNommed = Convert.ToInt32(row["BNommed"]),
                        BNomclient = row["BNomclient"].ToString(),
                        Bqte = Convert.ToInt32(row["Bqte"]),
                        Bdate = Convert.ToDateTime(row["Bdate"])
                    };
                    return sot;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
