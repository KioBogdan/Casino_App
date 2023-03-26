using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Atestat
{
    public partial class Bingo : Form
    {

        public decimal Balance_Utilizator;
        public decimal Bet_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;
        public bool Win = false;

        public Bingo(ref decimal Total_Balance, ref decimal Suma_Pariata, string Id_Actual, string Avatar)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox2.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox3.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox4.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox5.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox6.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox7.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox8.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox9.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox10.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox11.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox12.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox13.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox14.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox15.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox16.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox17.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox18.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox19.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox20.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox21.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox22.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox23.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox24.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox25.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox26.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox27.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox28.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox29.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox30.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox31.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox32.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox33.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox34.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox35.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox36.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox37.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox38.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox39.Image = Image.FromFile("Resources\\output-onlinepngtools.png");
            pictureBox40.Image = Image.FromFile("Resources\\output-onlinepngtools.png");


            button2.Enabled = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            pictureBox32.Visible = true;
            pictureBox34.Visible = true;
            pictureBox33.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            pictureBox37.Visible = true;
            pictureBox38.Visible = true;
            pictureBox39.Visible = true;
            pictureBox40.Visible = true;
            label6.Visible = true;
            for (int i = 1; i <= 5; i++)
            {
                gen_poz_nr(margs + 1, margj);
                margs = margj;
                margj += 15;
            }
            picList.Add(pictureBox1);
            picList.Add(pictureBox2);
            picList.Add(pictureBox3);
            picList.Add(pictureBox4);
            picList.Add(pictureBox5);
            picList.Add(pictureBox6);
            picList.Add(pictureBox7);
            picList.Add(pictureBox8);
            picList.Add(pictureBox9);
            picList.Add(pictureBox10);
            picList.Add(pictureBox11);
            picList.Add(pictureBox12);
            picList.Add(pictureBox13);
            picList.Add(pictureBox14);
            picList.Add(pictureBox15);
            picList.Add(pictureBox16);
            picList.Add(pictureBox17);
            picList.Add(pictureBox18);
            picList.Add(pictureBox19);
            picList.Add(pictureBox20);
            picList.Add(pictureBox21);
            picList.Add(pictureBox22);
            picList.Add(pictureBox23);
            picList.Add(pictureBox24);
            picList.Add(pictureBox25);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Bingo_detect_pic(picList[5 * j + i], randomList[5 * i + j]);
                    mat[j, i] = randomList[5 * i + j];
                }
            }

            Balance_Utilizator = Total_Balance;
            Bet_Utilizator = Suma_Pariata;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;

        }

        int[] vector = new int[76];
        int[] vector_ap = new int[76];
        int[,] mat = new int[5, 5];
        int[,] matrix = new int[5, 5];
        public Random rnd = new Random();
        public List<int> randomList = new List<int>();
        public List<int> random_gen = new List<int>();
        public List<PictureBox> picList = new List<PictureBox>();
        public List<PictureBox> generated_list = new List<PictureBox>();

        int margs = 1, margj = 15;

        bool verificare(int[,] a)
        {
            int OK;
            for (int k = 0; k < 5; k++)
            {
                OK = 1;
                for (int m = 1; m < 5; m++)
                    if (a[m, k] != a[m - 1, k])
                        OK = 0;
                    else
                        if (a[m, k] == 0 && a[m - 1, k] == 0)
                            OK = 0;
                if(OK==1)
                    return true;
            }

            for (int k = 0; k < 5; k++)
            {
                OK = 1;
                for (int m = 1; m < 5; m++)
                    if (a[k, m] != a[k, m - 1])
                        OK = 0;
                    else
                        if (a[k, m] == 0 && a[k, m - 1] == 0)
                            OK = 0;
                if (OK == 1)
                    return true;
            }
            return false;
        }

        void gen_poz_nr(int st, int dr)
        {
            int j=0;
            while (j < 5)
            {
                int var = rnd.Next(st, dr);
                if (!randomList.Contains(var))
                {
                    randomList.Add(var);
                    j++;
                }
            }
        }


        void Bingo_detect_pic(PictureBox x, int n)
        {
            if (n == 0)
                x.Image = Image.FromFile("Resources\\58afdad6829958a978a4a693.png");
            if (n == 1)
                x.Image = Image.FromFile("Resources\\1_t.png");
            if (n == 2)
                x.Image = Image.FromFile("Resources\\2.jpg");
            if (n == 3)
                x.Image = Image.FromFile("Resources\\3.jpg");
            if (n == 4)
                x.Image = Image.FromFile("Resources\\4.jpg");
            if (n == 5)
                x.Image = Image.FromFile("Resources\\5.jpg");
            if (n == 6)
                x.Image = Image.FromFile("Resources\\6.jpg");
            if (n == 7)
                x.Image = Image.FromFile("Resources\\7.jpg");
            if (n == 8)
                x.Image = Image.FromFile("Resources\\8.jpg");
            if (n == 9)
                x.Image = Image.FromFile("Resources\\9.jpg");
            if (n == 10)
                x.Image = Image.FromFile("Resources\\10.jpg");
            if (n == 11)
                x.Image = Image.FromFile("Resources\\11.jpg");
            if (n == 12)
                x.Image = Image.FromFile("Resources\\12.jpg");
            if (n == 13)
                x.Image = Image.FromFile("Resources\\13.jpg");
            if (n == 14)
                x.Image = Image.FromFile("Resources\\14.jpg");
            if (n == 15)
                x.Image = Image.FromFile("Resources\\15.jfif");
            if (n == 16)
                x.Image = Image.FromFile("Resources\\16.jpg");
            if (n == 17)
                x.Image = Image.FromFile("Resources\\17.jpg");
            if (n == 18)
                x.Image = Image.FromFile("Resources\\18.jpg");
            if (n == 19)
                x.Image = Image.FromFile("Resources\\19.jpg");
            if (n == 20)
                x.Image = Image.FromFile("Resources\\20.jpg");
            if (n == 21)
                x.Image = Image.FromFile("Resources\\21.jpg");
            if (n == 22)
                x.Image = Image.FromFile("Resources\\22.jpg");
            if (n == 23)
                x.Image = Image.FromFile("Resources\\23.jpg");
            if (n == 24)
                x.Image = Image.FromFile("Resources\\24.jpg");
            if (n == 25)
                x.Image = Image.FromFile("Resources\\25.jpg");
            if (n == 26)
                x.Image = Image.FromFile("Resources\\26.jpg");
            if (n == 27)
                x.Image = Image.FromFile("Resources\\27.jpg");
            if (n == 28)
                x.Image = Image.FromFile("Resources\\28.jpg");
            if (n == 29)
                x.Image = Image.FromFile("Resources\\29.jpg");
            if (n == 30)
                x.Image = Image.FromFile("Resources\\30.jpg");
            if (n == 31)
                x.Image = Image.FromFile("Resources\\31.jpg");
            if (n == 32)
                x.Image = Image.FromFile("Resources\\32.jpg");
            if (n == 33)
                x.Image = Image.FromFile("Resources\\33.jpg");
            if (n == 34)
                x.Image = Image.FromFile("Resources\\34.jpg");
            if (n == 35)
                x.Image = Image.FromFile("Resources\\35.jpg");
            if (n == 36)
                x.Image = Image.FromFile("Resources\\36.jpg");
            if (n == 37)
                x.Image = Image.FromFile("Resources\\37.jpg");
            if (n == 38)
                x.Image = Image.FromFile("Resources\\38.jpg");
            if (n == 39)
                x.Image = Image.FromFile("Resources\\39.jpg");
            if (n == 40)
                x.Image = Image.FromFile("Resources\\40.jpg");
            if (n == 41)
                x.Image = Image.FromFile("Resources\\41.jfif");
            if (n == 42)
                x.Image = Image.FromFile("Resources\\42.jpg");
            if (n == 43)
                x.Image = Image.FromFile("Resources\\43.jpg");
            if (n == 44)
                x.Image = Image.FromFile("Resources\\44.jpg");
            if (n == 45)
                x.Image = Image.FromFile("Resources\\45.jpg");
            if (n == 46)
                x.Image = Image.FromFile("Resources\\46.jpg");
            if (n == 47)
                x.Image = Image.FromFile("Resources\\47.jpg");
            if (n == 48)
                x.Image = Image.FromFile("Resources\\48.jpg");
            if (n == 49)
                x.Image = Image.FromFile("Resources\\49.jpg");
            if (n == 50)
                x.Image = Image.FromFile("Resources\\50.jpg");
            if (n == 51)
                x.Image = Image.FromFile("Resources\\51.jpg");
            if (n == 52)
                x.Image = Image.FromFile("Resources\\52.jpg");
            if (n == 53)
                x.Image = Image.FromFile("Resources\\53.jpg");
            if (n == 54)
                x.Image = Image.FromFile("Resources\\54.jpg");
            if (n == 55)
                x.Image = Image.FromFile("Resources\\55.jpg");
            if (n == 56)
                x.Image = Image.FromFile("Resources\\56.jpg");
            if (n == 57)
                x.Image = Image.FromFile("Resources\\57.jpg");
            if (n == 58)
                x.Image = Image.FromFile("Resources\\58.jpg");
            if (n == 59)
                x.Image = Image.FromFile("Resources\\59.jpg");
            if (n == 60)
                x.Image = Image.FromFile("Resources\\60.jpg");
            if (n == 61)
                x.Image = Image.FromFile("Resources\\61.jpg");
            if (n == 62)
                x.Image = Image.FromFile("Resources\\62.jpg");
            if (n == 63)
                x.Image = Image.FromFile("Resources\\63.jfif");
            if (n == 64)
                x.Image = Image.FromFile("Resources\\64.jpg");
            if (n == 65)
                x.Image = Image.FromFile("Resources\\65.jpg");
            if (n == 66)
                x.Image = Image.FromFile("Resources\\66.jpg");
            if (n == 67)
                x.Image = Image.FromFile("Resources\\67.jpg");
            if (n == 68)
                x.Image = Image.FromFile("Resources\\68.jpg");
            if (n == 69)
                x.Image = Image.FromFile("Resources\\69.jpg");
            if (n == 70)
                x.Image = Image.FromFile("Resources\\70.jpg");
            if (n == 71)
                x.Image = Image.FromFile("Resources\\71.jfif");
            if (n == 72)
                x.Image = Image.FromFile("Resources\\72.jfif");
            if (n == 73)
                x.Image = Image.FromFile("Resources\\73.jpg");
            if (n == 74)
                x.Image = Image.FromFile("Resources\\74.jfif");
            if (n == 75)
                x.Image = Image.FromFile("Resources\\75.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            pictureBox32.Visible = true;
            pictureBox34.Visible = true;
            pictureBox33.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            pictureBox37.Visible = true;
            pictureBox38.Visible = true;
            pictureBox39.Visible = true;
            pictureBox40.Visible = true;
            label6.Visible = true;
            for (int i = 1; i <= 5; i++)
            {
                gen_poz_nr(margs + 1, margj);
                margs = margj;
                margj += 15;
            }
            picList.Add(pictureBox1);
            picList.Add(pictureBox2);
            picList.Add(pictureBox3);
            picList.Add(pictureBox4);
            picList.Add(pictureBox5);
            picList.Add(pictureBox6);
            picList.Add(pictureBox7);
            picList.Add(pictureBox8);
            picList.Add(pictureBox9);
            picList.Add(pictureBox10);
            picList.Add(pictureBox11);
            picList.Add(pictureBox12);
            picList.Add(pictureBox13);
            picList.Add(pictureBox14);
            picList.Add(pictureBox15);
            picList.Add(pictureBox16);
            picList.Add(pictureBox17);
            picList.Add(pictureBox18);
            picList.Add(pictureBox19);
            picList.Add(pictureBox20);
            picList.Add(pictureBox21);
            picList.Add(pictureBox22);
            picList.Add(pictureBox23);
            picList.Add(pictureBox24);
            picList.Add(pictureBox25);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Bingo_detect_pic(picList[5 * j + i], randomList[5 * i + j]);
                    mat[j, i] = randomList[5 * i + j];
                }
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            Pen MyPen = new Pen(Brushes.Red, 10);
            Font MyFont = new Font("Arial", 14);
            float x = 0f;
            float y = 0f;
            float xSpace = panel1.Width / 5;
            float ySpace = panel1.Height / 5;

            for (int i = 0; i <= 5; i++)
            {
                gr.DrawLine(MyPen, x, y, x, panel1.Height);
                x += xSpace;
            }

            x = 0f;

            for (int i = 0; i <= 5; i++)
            {
                gr.DrawLine(MyPen, x, y, panel1.Width, y);
                y += ySpace;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generated_list.Add(pictureBox26);
            generated_list.Add(pictureBox27);
            generated_list.Add(pictureBox28);
            generated_list.Add(pictureBox29);
            generated_list.Add(pictureBox30);
            generated_list.Add(pictureBox31);
            generated_list.Add(pictureBox32);
            generated_list.Add(pictureBox33);
            generated_list.Add(pictureBox34);
            generated_list.Add(pictureBox35);
            generated_list.Add(pictureBox36);
            generated_list.Add(pictureBox37);
            generated_list.Add(pictureBox38);
            generated_list.Add(pictureBox39);
            generated_list.Add(pictureBox40);
            int j=0;
            while(j<15)
            {
                int var = rnd.Next(1, 75);
                if (!random_gen.Contains(var))
                {
                    random_gen.Add(var);
                    j++;
                }
            }

            for (int i = 0; i < 15; i++)
                Bingo_detect_pic(generated_list[i], random_gen[i]);

                for (int l = 0; l < random_gen.Count; l++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int m = 0; m < 5; m++)
                            if (mat[m, k] == random_gen[l])
                            {
                                matrix[m, k] = 1;
                                Bingo_detect_pic(picList[5 * m + k], 0);
                            }
                    }
                }
                button2.Enabled = false;
                pictureBox41.Visible = true;
                pictureBox42.Visible = true;
                if (verificare(matrix) == true)
                {
                   MessageBox.Show("YOU WON!");
                   Win = true;
                }
                else
                    MessageBox.Show("YOU LOST!");
                button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet13.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet13.Inregistrari);

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            if (Win == true)
            {
                Balance_Utilizator = Balance_Utilizator * 10;
                this.Close();
                Bingo_Bet f = new Bingo_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
                f.Show();
            }
            else
            {
                Balance_Utilizator = Balance_Utilizator - Bet_Utilizator;
                this.Close();
                Bingo_Bet f = new Bingo_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
                f.Show();
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            if (Win == true)
            {
                Balance_Utilizator = Balance_Utilizator * 10;
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