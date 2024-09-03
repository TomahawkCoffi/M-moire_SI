using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Mémoire_SI.Model
{
    internal class Entree_de_stock
    {
        public int LId { get; set; }
        public int Lmednom { get; set; }
        public int Lfnom { get; set; }
        public int Lqte { get; set; }
        public DateTime Ldateliv { get; set;}
        public DateTime Ldateper { get; set; }

        private SqlConnection con = DbConfig.con;

        public bool Save(Entree_de_stock ent)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO livraison (Lmednom,Lfnom,Lqte,Ldateliv,Ldateper)values(@LM,@LF,@LQ,@LDA,@LDE)", con);
                cmd.Parameters.AddWithValue("@LM", ent.Lmednom);
                cmd.Parameters.AddWithValue("@LF", ent.Lfnom);
                cmd.Parameters.AddWithValue("@LQ", ent.Lqte);
                cmd.Parameters.AddWithValue("@LDA", ent.Ldateliv);
                cmd.Parameters.AddWithValue("@LDE", ent.Ldateper);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Entrée de stock enregistrée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }

        public bool Update(Entree_de_stock ent)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE livraison SET Lmednom=@LM,Lfnom=@LF,Lqte=@LQ,Ldateliv=@LDA,Ldateper=@LDE WHERE LId=@Lkey", con);
                cmd.Parameters.AddWithValue("@LM", ent.Lmednom);
                cmd.Parameters.AddWithValue("@LF", ent.Lfnom);
                cmd.Parameters.AddWithValue("@LQ", ent.Lqte);
                cmd.Parameters.AddWithValue("@LDA", ent.Ldateliv);
                cmd.Parameters.AddWithValue("@LDE", ent.Ldateper);
                cmd.Parameters.AddWithValue("@Lkey", ent.LId);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Information modifiée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }
        public bool Delete(Entree_de_stock ent)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM livraison WHERE LId=@Lkey", con);
                cmd.Parameters.AddWithValue("@Lkey", ent.LId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("entrée de stock supprimé");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public object Get()
        {
            // table livraison            id: LId  nom:Lmednom

            // table med_tbl              id: MedId    nom:Mednom

            // table fournisseurs_tbl     id: FId  nom: Fnom


            try
            {  
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT stk.LId AS Id, med.Mednom AS Medicament, fsr.Fnom AS Fournisseur, stk.Lqte AS Quantity, stk.Ldateliv AS DateLivraison, stk.Ldateper AS DatePeromption from livraison stk LEFT JOIN med_tbl med ON stk.Lmednom = med.MedId LEFT JOIN fournisseurs_tbl fsr ON stk.Lfnom = fsr.FId", con);
                adap.Fill(dt);
                con.Close();

                return dt;
                /*List<Entree_de_stock> ents = new List<Entree_de_stock>();


                
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    MessageBox.Show()
                    Entree_de_stock ent = new Entree_de_stock();
                    var row = dt.Rows[i];
                    ent.LId = int.Parse(row["Id"].ToString());
                    ent.Lmednom = int.Parse(row["Medicament"].ToString());
                    ent.Lfnom = int.Parse(row["Fournisseur"].ToString());
                    ent.Lqte = int.Parse(row["Quantity"].ToString());
                    ent.Ldateliv = DateTime.Parse(row["DateLivraison"].ToString());
                    ent.Ldateper = DateTime.Parse(row["DatePeromption"].ToString());

                    ents.Add(ent);
                }
                return ents;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }

        }

        public Entree_de_stock FindOneById(int key)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter($"SELECT * from livraison WHERE LId={key}", con);
                adap.Fill(dt);
                con.Close();
                List<Entree_de_stock> ents = new List<Entree_de_stock>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Entree_de_stock ent = new Entree_de_stock();
                    var row = dt.Rows[i];
                    ent.LId = int.Parse(row["LId"].ToString());
                    ent.Lmednom = int.Parse(row["Lmednom"].ToString());
                    ent.Lfnom = int.Parse(row["Lfnom"].ToString());
                    ent.Lqte = int.Parse(row["Lqte"].ToString());
                    ent.Ldateliv = DateTime.Parse(row["Ldateliv"].ToString());
                    ent.Ldateper = DateTime.Parse(row["Ldateper"].ToString());

                    ents.Add(ent);
                }
                return ents[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }



    }
}
