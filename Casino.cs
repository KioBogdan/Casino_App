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
    public partial class Casino : Form
    {

        public decimal Balance_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;

        public Casino(ref decimal Bani_User , ref string Avatar_User , string Id_User,ref DataGridView Inregistrari)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Avatar_User);
            string Text_Id = "(" + Id_User + ")";
            string Text_Bani = Bani_User.ToString();
            label1.Text = Text_Id;
            label2.Text = Text_Bani;
            Avatar_Utilizator = Avatar_User;
            Balance_Utilizator = Bani_User;
            Id_Utilizator = Id_User;

            
            SqlConnection connection;
            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query = new SqlCommand("UPDATE Inregistrari SET Bani = @Amount WHERE ID = @UserId", connection);
                query.Parameters.Add(new SqlParameter("@Amount", Balance_Utilizator));
                query.Parameters.Add(new SqlParameter("@UserId", Id_Utilizator));
                SqlDataAdapter adapter = new SqlDataAdapter(query);

                DataSet new_ds = new DataSet();
                int result = adapter.Fill(new_ds, "Inregistrari");
                Inregistrari.DataSource = new_ds.Tables["Inregistrari"];
            }
            connection.Close();
        }

        private void Casino_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet4.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet4.Inregistrari);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            BlackJack_Bet f = new BlackJack_Bet(ref Balance_Utilizator, Id_Utilizator ,ref Avatar_Utilizator);
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Slots_Bet f = new Slots_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
            f.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Bingo_Bet f = new Bingo_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            HILO_Bet f = new HILO_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Avatar f = new Avatar(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator, ref Inregistrari);
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Deposit f = new Deposit(ref Balance_Utilizator, Id_Utilizator,Avatar_Utilizator, ref Inregistrari);
            f.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            Withdraw f = new Withdraw(ref Balance_Utilizator, Id_Utilizator, Avatar_Utilizator, ref Inregistrari);
            f.ShowDialog();
        }
    }
}
