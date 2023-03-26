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
    public partial class HILO : Form
    {
        public decimal Balance_Utilizator;
        public decimal Bet_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;
        public bool Win;
        public int Count;

        public HILO(ref decimal Total_Balance, ref decimal Suma_Pariata, string Id_Actual, string Avatar)
        {
            InitializeComponent();
            HI_LO_Pic_1.Image = Image.FromFile("Resources\\HI_bani_trans.png");
            HI_LO_pic2.Image = Image.FromFile("Resources\\HI_bani_trans.png");
            HI_LO_pictureBox4.Image = Image.FromFile("Resources\\HI_Carti.png");
            pictureBox1.Image = Image.FromFile("Resources\\HI_inima_rosie.png");
            pictureBox2.Image = Image.FromFile("Resources\\HI_inima_rosie.png");
            pictureBox3.Image = Image.FromFile("Resources\\HI_inima_rosie.png");
            Balance_Utilizator = Total_Balance;
            Bet_Utilizator = Suma_Pariata;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;

            HI_LO_buton_HI.Visible = true;
            HI_LO_buton_LO.Visible = true;
            HI_LO_pictureBox4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            for (int i = 0; i < 52; i++)
            {
                if (i % 4 == 0)
                    mat_poz[i] = i / 4 - 1;
                else
                    mat_poz[i] = i / 4;
            }
            detect();
            HI_LO_detect_pic(HI_LO_Pic_1, val_Prim);

        }

        public List<int> Random_gen = new List<int>();
        public Random rnd = new Random();
        public int val, val_Prim, nr_Vieti=3;
        public int[] mat_poz = new int[52];
        
        public void detect()
        {
            int ok = 1;
            while (ok == 1)
            {
                val_Prim = rnd.Next(1, 52);
                if (!Random_gen.Contains(val_Prim))
                {
                    Random_gen.Add(val_Prim);
                    ok = 0;
                }
            }
        }

        public void detect1()
        {
            int ok = 1;
            while (ok == 1)
            {
                val = rnd.Next(1, 52);
                if (!Random_gen.Contains(val))
                {
                    Random_gen.Add(val);
                    ok = 0;
                }
            }
        }

        public bool verif_castig_HIGH(int p1, int p2)
        {
            if (mat_poz[p1]>mat_poz[p2])
                return false;
            else
                return true;
        }

        public bool verif_castig_LOW(int p1, int p2)
        {
            if (mat_poz[p1]<mat_poz[p2])
                return false;
            else 
                return true;
        }

        public void det_nr_vieti(int n)
        {
            if (n == 2)
                pictureBox3.Image = Image.FromFile("Resources\\HI_inima_empty.png");
            if (n == 1)
                pictureBox2.Image = Image.FromFile("Resources\\HI_inima_empty.png");
            if (n == 0)
            {
                pictureBox1.Image = Image.FromFile("Resources\\HI_inima_empty.png");
                MessageBox.Show("Game Over!");
                Win = false;
                HI_LO_buton_HI.Enabled = false;
                HI_LO_buton_LO.Enabled = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
            }
        }

        void HI_LO_detect_pic(PictureBox x, int n)
        {
            if (n == 1)
                x.Image = Image.FromFile("Resources\\HI_1-c.png");
            if (n == 2)
                x.Image = Image.FromFile("Resources\\HI_1-d.png");
            if (n == 3)
                x.Image = Image.FromFile("Resources\\HI_1-h.png");
            if (n == 4)
                x.Image = Image.FromFile("Resources\\HI_1-s.png");
            if (n == 5)
                x.Image = Image.FromFile("Resources\\HI_2-c.png");
            if (n == 6)
                x.Image = Image.FromFile("Resources\\HI_2-d.png");
            if (n == 7)
                x.Image = Image.FromFile("Resources\\HI_2-h.png");
            if (n == 8)
                x.Image = Image.FromFile("Resources\\HI_2-s.png");
            if (n == 9)
                x.Image = Image.FromFile("Resources\\HI_3-c.png");
            if (n == 10)
                x.Image = Image.FromFile("Resources\\HI_3-d.png");
            if (n == 11)
                x.Image = Image.FromFile("Resources\\HI_3-h.png");
            if (n == 12)
                x.Image = Image.FromFile("Resources\\HI_3-s.png");
            if (n == 13)
                x.Image = Image.FromFile("Resources\\HI_4-c.png");
            if (n == 14)
                x.Image = Image.FromFile("Resources\\HI_4-d.png");
            if (n == 15)
                x.Image = Image.FromFile("Resources\\HI_4-h.png");
            if (n == 16)
                x.Image = Image.FromFile("Resources\\HI_4-s.png");
            if (n == 17)
                x.Image = Image.FromFile("Resources\\HI_5-c.png");
            if (n == 18)
                x.Image = Image.FromFile("Resources\\HI_5-d.png");
            if (n == 19)
                x.Image = Image.FromFile("Resources\\HI_5-h.png");
            if (n == 20)
                x.Image = Image.FromFile("Resources\\HI_5-s.png");
            if (n == 21)
                x.Image = Image.FromFile("Resources\\HI_6-c.png");
            if (n == 22)
                x.Image = Image.FromFile("Resources\\HI_6-d.png");
            if (n == 23)
                x.Image = Image.FromFile("Resources\\HI_6-h.png");
            if (n == 24)
                x.Image = Image.FromFile("Resources\\HI_6-s.png");
            if (n == 25)
                x.Image = Image.FromFile("Resources\\HI_7-c.png");
            if (n == 26)
                x.Image = Image.FromFile("Resources\\HI_7-d.png");
            if (n == 27)
                x.Image = Image.FromFile("Resources\\HI_7-h.png");
            if (n == 28)
                x.Image = Image.FromFile("Resources\\HI_7-s.png");
            if (n == 29)
                x.Image = Image.FromFile("Resources\\HI_8-c.png");
            if (n == 30)
                x.Image = Image.FromFile("Resources\\HI_8-d.png");
            if (n == 31)
                x.Image = Image.FromFile("Resources\\HI_8-h.png");
            if (n == 32)
                x.Image = Image.FromFile("Resources\\HI_8-s.png");
            if (n == 33)
                x.Image = Image.FromFile("Resources\\HI_9-c.png");
            if (n == 34)
                x.Image = Image.FromFile("Resources\\HI_9-d.png");
            if (n == 35)
                x.Image = Image.FromFile("Resources\\HI_9-h.png");
            if (n == 36)
                x.Image = Image.FromFile("Resources\\HI_9-s.png");
            if (n == 37)
                x.Image = Image.FromFile("Resources\\HI_10-c.png");
            if (n == 38)
                x.Image = Image.FromFile("Resources\\HI_10-d.png");
            if (n == 39)
                x.Image = Image.FromFile("Resources\\HI_10-h.png");
            if (n == 40)
                x.Image = Image.FromFile("Resources\\HI_10-s.png");
            if (n == 41)
                x.Image = Image.FromFile("Resources\\HI_11-c.png");
            if (n == 42)
                x.Image = Image.FromFile("Resources\\HI_11-d.png");
            if (n == 43)
                x.Image = Image.FromFile("Resources\\HI_11-h.png");
            if (n == 44)
                x.Image = Image.FromFile("Resources\\HI_11-s.png");
            if (n == 45)
                x.Image = Image.FromFile("Resources\\HI_12-c.png");
            if (n == 46)
                x.Image = Image.FromFile("Resources\\HI_12-d.png");
            if (n == 47)
                x.Image = Image.FromFile("Resources\\HI_12-h.png");
            if (n == 48)
                x.Image = Image.FromFile("Resources\\HI_12-s.png");
            if (n == 49)
                x.Image = Image.FromFile("Resources\\HI_13-c.png");
            if (n == 50)
                x.Image = Image.FromFile("Resources\\HI_13-d.png");
            if (n == 51)
                x.Image = Image.FromFile("Resources\\HI_13-h.png");
            if (n == 52)
                x.Image = Image.FromFile("Resources\\HI_13-s.png");
        }



        private void HI_LO_buton_HI_Click(object sender, EventArgs e)
        {
            detect1();
            HI_LO_detect_pic(HI_LO_pic2, val);
            if (verif_castig_HIGH(val_Prim, val) == true)
            {
                MessageBox.Show("You Won!");
                Count++;
                if (Count == 3)
                {
                    Win = true;
                    HI_LO_buton_HI.Enabled = false;
                    HI_LO_buton_LO.Enabled = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                }
                val_Prim=val;
                HI_LO_detect_pic(HI_LO_Pic_1, val_Prim);
                HI_LO_pic2.Image = Image.FromFile("Resources\\HI_bani_trans.png");
            }
            else
            {
                MessageBox.Show("You Lost!");
                Count = 0;
                nr_Vieti--;
                det_nr_vieti(nr_Vieti);
                val_Prim = val;
                HI_LO_detect_pic(HI_LO_Pic_1, val_Prim);
                HI_LO_pic2.Image = Image.FromFile("Resources\\HI_bani_trans.png");
            }
                
        }

        private void HI_LO_buton_LO_Click(object sender, EventArgs e)
        {
            detect1();
            HI_LO_detect_pic(HI_LO_pic2, val);
            if (verif_castig_LOW(val_Prim, val) == true)
            {
                MessageBox.Show("You Won!");
                val_Prim = val;
                HI_LO_detect_pic(HI_LO_Pic_1, val_Prim);
                HI_LO_pic2.Image = Image.FromFile("Resources\\HI_bani_trans.png");
                Count++;
                if (Count == 3)
                {
                    Win = true;
                    HI_LO_buton_HI.Enabled = false;
                    HI_LO_buton_LO.Enabled = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("You Lost!");
                nr_Vieti--;
                Count = 0;
                det_nr_vieti(nr_Vieti);
                val_Prim = val;
                HI_LO_detect_pic(HI_LO_Pic_1, val_Prim);
                HI_LO_pic2.Image = Image.FromFile("Resources\\HI_bani_trans.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet12.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet12.Inregistrari);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Win == true)
            {
                Balance_Utilizator = Balance_Utilizator + Bet_Utilizator;
                this.Close();
                HILO_Bet f = new HILO_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
                f.Show();
            }
            else
            {
                Balance_Utilizator = Balance_Utilizator - Bet_Utilizator;
                this.Close();
                HILO_Bet f = new HILO_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
                f.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Win == true)
            {
                Balance_Utilizator = Balance_Utilizator + Bet_Utilizator;
                this.Close();
                Casino Home = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
                Home.Show();
            }
            else
            {
                Balance_Utilizator = Balance_Utilizator - Bet_Utilizator;
                this.Close();
                Casino Home = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator, ref Inregistrari);
                Home.Show();
            }
        }
    }
}
