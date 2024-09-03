using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data;
using Microsoft.Data.SqlClient;
using Guna.UI2.HtmlRenderer.Adapters;

namespace Mémoire_SI.Model
{
    internal class Categorie
    {
        public int CId { get; set; }
        public string Catnom { get; set; }

        private SqlConnection con = DbConfig.con;

        public bool Save(Categorie cat)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO category(Catnom)values(@CN)", con);
                cmd.Parameters.AddWithValue("@CN", cat.Catnom);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catégorie ajoutée");

                con.Close();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public bool Update(Categorie cat) 
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE category SET Catnom=@CN WHERE Cid=@Ckey", con);
                cmd.Parameters.AddWithValue("@CN", cat.Catnom);
                cmd.Parameters.AddWithValue("@Ckey", cat.CId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Catégorie modifiée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public bool Delete(Categorie cat) 
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM category WHERE CId=@Ckey", con);
                cmd.Parameters.AddWithValue("@Ckey", cat.CId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Catégorie supprimée");

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

        public List<Categorie> Get()
        {
            try
            {
                con.Open();
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * from category", con);
                /*SqlCommandBuilder builder = new SqlCommandBuilder(sda);*/
                adap.Fill(dt);
                con.Close();
                List<Categorie> cats = new List<Categorie>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Categorie cat = new Categorie();
                    var row = dt.Rows[i];
                    cat.CId = int.Parse(row["CId"].ToString());
                    cat.Catnom = row["Catnom"].ToString();
                    cats.Add(cat);
                }
                return cats;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }


        public Categorie FindOneById(int key)
        {
            try
            {
                con.Open();
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter($"SELECT * from category WHERE CId={key}", con);
                /*SqlCommandBuilder builder = new SqlCommandBuilder(sda);*/
                adap.Fill(dt);
                con.Close();
                List<Categorie> cats = new List<Categorie>();
                for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    Categorie cat = new Categorie();
                    var row = dt.Rows[i];
                    cat.CId = int.Parse(row["CId"].ToString());
                    cat.Catnom = row["Catnom"].ToString();
                    cats.Add(cat);
                }
                return cats[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

        public void categorydropdown(Guna.UI2.WinForms.Guna2ComboBox medcatcb)
        {
            List<Categorie> cats = new List<Categorie>();

            foreach(Categorie cat in this.Get())
            {
                cats.Add(new Categorie() { Catnom = cat.Catnom , CId= cat.CId});
            }
            medcatcb.DataSource = cats;
            medcatcb.DisplayMember = "Catnom";
            medcatcb.ValueMember = "CId";
        }


    }



}
