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
    public partial class Avatar : Form
    {
        public Avatar()
        {
            InitializeComponent();
        }

        public string Id_Utilizator;
        public string Avatar_Utilizator = "";
        public decimal Balance_Utilizator;
        bool locked = false;
        bool selected = false;

        public Avatar(ref decimal Suma_Pariata , string Id_Actual, ref string Avatar, ref DataGridView Inregistrari)
        {
            InitializeComponent();
            Balance_Utilizator = Suma_Pariata;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            Avatar_Utilizator = "Avatar7.png";
        }

        private void Avatar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet10.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet10.Inregistrari);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar4.png";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar1.png";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar3.png";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar10.png";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar8.png";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar5.png";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar9.png";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = true;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar2.png";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar6.png";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar11.png";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = true;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar12.png";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = true;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar13.png";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = true;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar14.png";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar15.png";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = true;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar16.png";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = true;
            label19.Visible = false;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar17.png";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            locked = true;
            selected = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = true;
            label20.Visible = false;
            Avatar_Utilizator = "Avatar18.png";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (locked == false)
            {
                this.Close();
                Casino Pub = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
                Pub.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected == false)
                label20.Visible = true;
            else
            {

                SqlConnection connection;
                using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand("UPDATE Inregistrari SET Avatar = @Imag WHERE ID = @UserId", connection);
                    query.Parameters.Add(new SqlParameter("@Imag", Avatar_Utilizator));
                    query.Parameters.Add(new SqlParameter("@UserId", Id_Utilizator));
                    SqlDataAdapter adapter = new SqlDataAdapter(query);

                    DataSet new_ds = new DataSet();
                    int result = adapter.Fill(new_ds, "Inregistrari");
                    Inregistrari.DataSource = new_ds.Tables["Inregistrari"];
                }
                connection.Close();

                this.Close();
                Casino Pub = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
                Pub.Show();
            }
        }
    }
}
