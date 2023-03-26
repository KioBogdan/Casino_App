using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Logare : Form
    {

        private Autentificare Autentif;
        public string Mail = "";
        public string Parola = "";

        public decimal Bani_User = 0;
        public string Avatar_User = "";
        public string Id_User = "";

        public Logare(string Adresa_Mail)
        {
            Autentif = new Autentificare();
            InitializeComponent();
            textBox1.Text = Adresa_Mail;
        }

        public Logare()
        {
            Autentif = new Autentificare();
            InitializeComponent();
        }

        private void Logare_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            // TODO: This line of code loads data into the 'jucatoriDataSet2.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter1.Fill(this.jucatoriDataSet2.Inregistrari);
            // TODO: This line of code loads data into the 'jucatoriDataSet1.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet1.Inregistrari);

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            label3.Visible = false;
            label4.Visible = false;
            Mail = textBox1.Text.ToString();
            Parola = textBox2.Text.ToString();

            bool Validare_Mail = true;
            bool Validare_Parola = true;
            Validare_Mail = Autentif.DataBase_Validare_Adresa(Mail);
            Validare_Parola = Autentif.DataBase_ParolaLength(Parola);

            Bani_User = 0;
            Avatar_User = "";
            Id_User = "";


            if (Validare_Mail == false)
            {
                label3.Visible = true;
                label3.Text = "(invalid mail format)";
                textBox2.Clear();
            }
            else
            {
                if (Validare_Parola == false)
                {
                    label4.Visible = true;
                    label4.Text = "(minimum 5 characters)";
                    textBox2.Clear();
                }
                else
                {
                    String Date_Valide = Autentif.DataBase_Logare(Mail, Parola);
                    if (String.Compare(Date_Valide, "Login successfully!") == 0)
                    {
                        MessageBox.Show("Login successfully!");
                        this.Close();
                        Autentif.DataBase_SelectarePersoana(Mail, Parola, ref Bani_User, ref Avatar_User, ref Id_User);
                        Casino f = new Casino(ref Bani_User, ref Avatar_User, Id_User,ref Inregistrari);
                        f.ShowDialog();

                    }
                    else
                    {
                        if (String.Compare(Date_Valide, "Invalid mail/password!") == 0)
                        {
                            label3.Visible = true;
                            label3.Text = "Invalid mail/password!";
                            textBox2.Clear();
                        }
                        else
                        {
                            Register f = new Register();
                            MessageBox.Show("Don't have an account?Register!");
                            this.Close();
                            f.ShowDialog();
                            textBox2.Clear();
                        }
                    }
                }
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub Back = new Hub();
            Back.Show();
        }
    }
}
