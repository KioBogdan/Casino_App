using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Atestat
{
    public partial class Slots : Form
    {

        public decimal Balance_Utilizator;
        public decimal Bet_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;
        public bool Win = false;

        public Slots(ref decimal Total_Balance, ref decimal Suma_Pariata, string Id_Actual, string Avatar)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Resources\\Dolar1.png");
            pictureBox2.Image = Image.FromFile("Resources\\Dolar1.png");
            pictureBox3.Image = Image.FromFile("Resources\\Dolar1.png");

            label_nume_slots.Text = "~Slots~";
            timer1.Enabled = true;
            this.player.SoundLocation = @"D:\Visual Studio 2010\Atestat_Casino\Atestat\Atestat\Resources\masina_sunet.wav";
            this.player.PlayLooping();

            Balance_Utilizator = Total_Balance;
            Bet_Utilizator = Suma_Pariata;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;

        }

        private SoundPlayer player = new SoundPlayer();
        private SoundPlayer player2 = new SoundPlayer();
        private SoundPlayer player3 = new SoundPlayer();

        Random rnd = new Random();
        int poz1, poz2, poz3, dep;


        void calcul_cast()
        {
            if (poz1 != poz2 || poz1 != poz3 || poz2 != poz3)
            {
                label_nume_slots.Text = "YOU LOST!";
                Win = false;
                this.player2.SoundLocation = @"D:\Visual Studio 2010\Atestat_Casino\Atestat\Atestat\Resources\Lost_sound.wav";
                this.player2.Play();
            }
            else
            {
                Win = true;
                label_nume_slots.Text = "YOU WON!";
                this.player3.SoundLocation = @"D:\Visual Studio 2010\Atestat_Casino\Atestat\Atestat\Resources\Win_sound.wav";
                this.player3.Play();
            }
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            Pen MyPen = new Pen(Brushes.SaddleBrown, 10);
            Font MyFont = new Font("Arial", 14);
            float x = 0f;
            float y = 0f;
            float xSpace = panel1.Width / 3;
            float ySpace = panel1.Height;

            for (int i = 0; i <= 3; i++)
            {
                gr.DrawLine(MyPen, x, y, x, panel1.Height);
                x += xSpace;
            }

            x = 0f;

            for (int i = 0; i < 2; i++)
            {
                gr.DrawLine(MyPen, x, y, panel1.Width, y);
                y += ySpace;
            }
        }

        private void buton_play_Click(object sender, EventArgs e)
        {
            label_nume_slots.Text = "~Slots~";
            timer1.Enabled = true;
            this.player.SoundLocation = @"D:\Visual Studio 2010\Atestat_Casino\Atestat\Atestat\Resources\masina_sunet.wav";
            this.player.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dep++;
            if (dep < 20)
            {
                poz1 = rnd.Next(1, 4);
                poz2 = rnd.Next(1, 4);
                poz3 = rnd.Next(1, 4);

                switch (poz1)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile("Resources\\Pepene1.png");
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("Resources\\Septar1.png");
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("Resources\\Struguri1.png");
                        break;
                }

                switch (poz2)
                {
                    case 1:
                        pictureBox2.Image = Image.FromFile("Resources\\Pepene1.png");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile("Resources\\Septar1.png");
                        break;
                    case 3:
                        pictureBox2.Image = Image.FromFile("Resources\\Struguri1.png");
                        break;
                }

                switch (poz3)
                {
                    case 1:
                        pictureBox3.Image = Image.FromFile("Resources\\Pepene1.png");
                        break;
                    case 2:
                        pictureBox3.Image = Image.FromFile("Resources\\Septar1.png");
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile("Resources\\Struguri1.png");
                        break;
                }


            }
            else
            {
                timer1.Enabled = false;
                dep = 0;
                this.player.Stop();
                calcul_cast();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet14.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet14.Inregistrari);

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Win == true)
            {
                Balance_Utilizator = Balance_Utilizator + Bet_Utilizator;
                this.Close();
                Slots_Bet f = new Slots_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
                f.Show();
            }
            else
            {
                Balance_Utilizator = Balance_Utilizator - Bet_Utilizator;
                this.Close();
                Slots_Bet f = new Slots_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
                f.Show();
            }
        }
    }
}