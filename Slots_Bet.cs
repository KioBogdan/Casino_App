﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Slots_Bet : Form
    {

        private Autentificare autentif3;
        public decimal Balance_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;

        public Slots_Bet()
        {
            InitializeComponent();
        }

        public Slots_Bet(ref decimal Suma_Pariata, string Id_Actual, ref string Avatar)
        {
            InitializeComponent();
            autentif3 = new Autentificare();
            label1.Text = "(current balance:" + Suma_Pariata.ToString() + ")";
            Balance_Utilizator = Suma_Pariata;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;
        }

        private void Slots_Bet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet7.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet7.Inregistrari);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Casino Pub = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
            Pub.Show();
        }

        private void buttonElipse1_Click(object sender, EventArgs e)
        {
            string Suma_Introdusa = textBox1.Text.ToString();
            bool Valid_Date = autentif3.DataBase_ValidareSuma(Suma_Introdusa);

            if (Valid_Date == false)
            {
                label2.Text = "(invalid sum passed!)";
                label2.Visible = true;
                textBox1.Clear();
            }
            else
            {
                decimal Suma_Pasata = decimal.Parse(Suma_Introdusa);
                if (Suma_Pasata > Balance_Utilizator)
                {
                    label2.Text = "(not enough balance!)";
                    textBox1.Clear();
                    label2.Visible = true;
                }
                else
                {
                    this.Close();
                    Slots f = new Slots(ref Balance_Utilizator, ref Suma_Pasata, Id_Utilizator, Avatar_Utilizator);
                    f.ShowDialog();
                }
            }
        }
    }
}
