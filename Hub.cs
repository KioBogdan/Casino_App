using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Atestat
{

    public partial class Hub : Form
    {

        private Autentificare autentif;
        private Autentificare autentif3;

        public int Total_Persoane = 0;

        public Hub()
        {
            autentif = new Autentificare();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucătoriDataSet.Conturi' table. You can move, or remove it, as needed.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logare f = new Logare();
            f.ShowDialog();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            autentif.DataBase_Stergere(Inregistrari);
        }

        private void Hub_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet3.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet3.Inregistrari);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BlackJack f = new BlackJack();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            autentif3 = new Autentificare();
            autentif.DataBase_Stergere(Inregistrari);
        }
    }
}
