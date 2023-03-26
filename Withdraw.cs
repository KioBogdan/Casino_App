using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Atestat
{
    public partial class Withdraw : Form
    {

        public decimal Balance_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;
        private Autentificare autentif3;

        public Withdraw(ref decimal Total_Balance, string Id_Actual, string Avatar, ref DataGridView Inregistrari)
        {
            InitializeComponent();
            autentif3 = new Autentificare();
            Balance_Utilizator = Total_Balance;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;
            label2.Text = label2.Text + Balance_Utilizator.ToString() + ")";
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet16.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet16.Inregistrari);

        }

        private void buttonElipse1_Click(object sender, EventArgs e)
        {
            string Suma_Introdusa = textBox1.Text.ToString();
            bool Valid_Date = false;
            Valid_Date = autentif3.DataBase_ValidareSuma(Suma_Introdusa);


            if (Valid_Date == false)
            {
                label1.Text = "(invalid sum passed!)";
                label1.Visible = true;
                textBox1.Clear();
            }
            else
            {
                decimal Suma_Pasata = decimal.Parse(Suma_Introdusa);
                if (Suma_Pasata > Balance_Utilizator)
                {
                    label1.Text = "(not enough balance!)";
                    textBox1.Clear();
                    label1.Visible = true;
                }
                else
                {

                    decimal Suma_Actuala = Balance_Utilizator - Suma_Pasata;

                    SqlConnection connection;
                    using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
                    {
                        connection.Open();
                        SqlCommand query = new SqlCommand("UPDATE Inregistrari SET Bani = @Amount WHERE ID = @UserId", connection);
                        query.Parameters.Add(new SqlParameter("@Amount", Suma_Actuala));
                        query.Parameters.Add(new SqlParameter("@UserId", Id_Utilizator));
                        SqlDataAdapter adapter = new SqlDataAdapter(query);

                        DataSet new_ds = new DataSet();
                        int result = adapter.Fill(new_ds, "Inregistrari");
                        Inregistrari.DataSource = new_ds.Tables["Inregistrari"];
                    }
                    connection.Close();

                    this.Close();
                    Casino Pub = new Casino(ref Suma_Actuala, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
                    Pub.Show();
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Casino Pub = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
            Pub.Show();
        }
    }
}
