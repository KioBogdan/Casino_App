using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Atestat
{
    public partial class Register : Form
    {

        private Autentificare Autentif;
        public bool Ap_Adresa = false;
        public bool Valid_Adresa = true;
        public bool Confirm_Parola = true;
        public bool Valid_Suma = true;
        public bool Valid_Lungime = true;
        public bool Check1 = false;
        public bool Check2 = false;
        public bool Valid_Avatar = true;
        public string Imagine = "";

        public bool ValidareSuma(string Bani)
        {
            string strRegex = @"^[1-9][0-9]{0,8}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Bani))
                return true;
            else
                return false;
        }

        public Register()
        {
            Autentif = new Autentificare();
            InitializeComponent();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            Valid_Avatar = true;
            Ap_Adresa = false;
            Valid_Adresa = true;
            Confirm_Parola = true;
            Valid_Suma = true;
            Valid_Lungime = true;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            string Adresa = textBox1.Text;
            string Parola = textBox2.Text;
            string Text_Parola = textBox3.Text;
            string Text_Bani = textBox4.Text;
            decimal Bani = 0;
            if (String.Compare("", Imagine) == 0)
                Valid_Avatar = false;
            if (ValidareSuma(Text_Bani) == false)
            {
                Valid_Suma = false;
                Autentif.DataBase_Inregistrare(Adresa, Parola, Text_Parola, Text_Bani, Bani, Imagine, ref Inregistrari, ref Ap_Adresa, ref Valid_Adresa, ref Confirm_Parola, ref Valid_Suma, ref Valid_Lungime, ref Valid_Avatar);
                if (Valid_Adresa == false)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    label5.Visible = true;
                    label5.Text = "(invalid adress)";
                }
                else
                {
                    if (Ap_Adresa == true)
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        label5.Text = "(account already registered)";
                        label5.Visible = true;
                    }
                    else
                    {
                        if (Valid_Lungime == false)
                        {
                            textBox4.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            label6.Visible = true;
                            label6.Text = "(minimum 5 characters)";
                        }
                        else
                        {
                            if (Confirm_Parola == false)
                            {
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                label6.Visible = true;
                                label6.Text = "(passwords not matching)";
                            }
                            else
                            {
                                if (Valid_Suma == false)
                                {
                                    label7.Visible = true;
                                    textBox4.Clear();
                                }
                                else
                                    label18.Visible = true;
                            }
                        }
                    }
                }
            }
            else
            {
                Bani = Decimal.Parse(textBox4.Text.ToString());
                Autentif.DataBase_Inregistrare(Adresa, Parola, Text_Parola, Text_Bani, Bani, Imagine ,ref Inregistrari, ref Ap_Adresa, ref Valid_Adresa, ref Confirm_Parola, ref Valid_Suma, ref Valid_Lungime, ref Valid_Avatar);
                if (Valid_Adresa == true && Ap_Adresa == false && Valid_Lungime == true && Confirm_Parola == true && Valid_Suma == true && Valid_Avatar == true)
                {
                    MessageBox.Show("Inregistrare cu succes!");
                    Logare f = new Logare(Adresa);
                    f.Show();
                    this.Close();
                }
                if (Valid_Adresa == false)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    label5.Visible = true;
                }
                else
                {
                    if (Ap_Adresa == true)
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        label5.Text = "(account already registered)";
                        label5.Visible = true;
                    }
                    else
                    {
                        if (Valid_Lungime == false)
                        {
                            textBox4.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            label6.Visible = true;
                            label6.Text = "(minimum 5 characters)";
                        }
                        else
                        {
                            if (Confirm_Parola == false)
                            {
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                label6.Visible = true;
                                label6.Text = "(passwords not matching)";
                            }
                            else
                                label18.Visible = true;
                        }
                    }
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet.Inregistrari);

        }


        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (Check1 == false)
                Check1 = true;
            else
                Check1 = false;
            if (Check1 == false)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (Check2 == false)
                Check2 = true;
            else
                Check2 = false;
            if (Check2 == false)
                textBox3.UseSystemPasswordChar = false;
            else
                textBox3.UseSystemPasswordChar = true;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar1.png";
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar2.png";
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar3.png";
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar4.png";
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar5.png";
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar6.png";
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar7.png";
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar8.png";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
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
            Imagine = "Avatar9.png";
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
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
            Imagine = "Avatar10.png";
        }

        
    }
}
