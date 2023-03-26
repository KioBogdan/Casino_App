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
    public partial class BlackJack : Form
    {

        //hscd

        public List<Carti> Date = new List<Carti>();
        public int Scor_Dealer;
        public int Scor_Player;
        public int Nr_Carti;
        public int Suma_Pariata;
        public int Valoare_Generata;
        public string Carte_Generata;
        public int Valoare_Carte_Dealer;
        public string Nume_Carte_Dealer;

        public decimal Balance_Utilizator;
        public decimal Bet_Utilizator;
        public string Avatar_Utilizator;
        public string Id_Utilizator;

        public void BlackJack_Generare_Carti(ref int Valoare, ref string Carte) //Se genereaza o carte care nu a fost aleasa din pachet inca
        {
            Random Var = new Random();
            int Val = Var.Next(2, 15);
            int Symb = Var.Next(1, 5);
            string Adresa_Carte = "";


            if (Symb == 1)
            {
                if (Date[Val].h == true)
                    BlackJack_Generare_Carti(ref Valoare, ref Carte);
                else
                {
                    Valoare = Val;
                    Carte = Adresa_Carte + Val.ToString() + "-" + "h" + ".png";
                    Date[Valoare].h = true;
                }
            }

            if (Symb == 2)
            {
                if (Date[Val].s == true)
                    BlackJack_Generare_Carti(ref Valoare, ref Carte);
                else
                {
                    Valoare = Val;
                    Carte = Adresa_Carte + Val.ToString() + "-" + "s" + ".png";
                    Date[Valoare].s = true;
                }
            }

            if (Symb == 3)
            {
                if (Date[Val].c == true)
                    BlackJack_Generare_Carti(ref Valoare, ref Carte);
                else
                {
                    Valoare = Val;
                    Carte = Adresa_Carte + Val.ToString() + "-" + "c" + ".png";
                    Date[Valoare].c = true;
                }
            }

            if (Symb == 4)
            {
                if (Date[Val].d == true)
                    BlackJack_Generare_Carti(ref Valoare, ref Carte);
                else
                {
                    Valoare = Val;
                    Carte = Adresa_Carte + Val.ToString() + "-" + "d" + ".png";
                    Date[Valoare].d = true;
                }
            }

        }

        public void BlackJack_Afisare() //Se afiseaza valorile care au fost alese pana la acest moment
        {
            string Output = "Hearts         Spades         Clubs           Diamonds" + "\n" + "\n";
            int Nr_Carte = 2;
            for (int i = 2; i <= 14; ++i)
            {
                Output =Output +  Nr_Carte.ToString() + " ";
                Output = Output + Date[i].h.ToString() + "         " + Date[i].s.ToString() + "         " + Date[i].c.ToString() + "         " + Date[i].d.ToString() + "\n";
                Nr_Carte++;
            }
            MessageBox.Show(Output);
        }

        public void BlackJack_Start_Joc_BlackJack(ref int Scor_Dealer , ref int Scor_Player)
        {
            label9.Visible = true;
            label12.Visible = true;
            HIT.Visible = true;
            STAND.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            Valoare_Generata = 0;
            Carte_Generata = "";
            BlackJack_Generare_Carti(ref Valoare_Generata, ref Carte_Generata);
            Scor_Dealer = Scor_Dealer + Valoare_Generata;
            pictureBox2.Image = Image.FromFile(Carte_Generata);
            pictureBox3.Image = Image.FromFile("back.jpg");
            BlackJack_Generare_Carti(ref Valoare_Generata, ref Carte_Generata);
            Scor_Player = Scor_Player + Valoare_Generata;
            pictureBox4.Image = Image.FromFile(Carte_Generata);
            pictureBox5.Image = Image.FromFile("back.jpg");
            Nr_Carti = Nr_Carti + 1;
            BlackJack_Generare_Carti(ref Valoare_Carte_Dealer, ref Nume_Carte_Dealer);
            label9.Text = Scor_Dealer.ToString();
            label12.Text = Scor_Player.ToString();
        }

        public void BlackJack_HITT()
        {
            Valoare_Generata = 0;
            Carte_Generata = "";
            BlackJack_Generare_Carti(ref Valoare_Generata, ref Carte_Generata);
            Scor_Player = Scor_Player + Valoare_Generata;
            label12.Text = Scor_Player.ToString();
            Nr_Carti = Nr_Carti + 1;
            if (Nr_Carti == 2)
            {
                pictureBox5.Visible = true;
                pictureBox5.Image = Image.FromFile(Carte_Generata);
                pictureBox6.Visible = true;
                pictureBox6.Image = Image.FromFile("back.jpg");
            }
            if (Nr_Carti == 3)
            {
                pictureBox6.Visible = true;
                pictureBox6.Image = Image.FromFile(Carte_Generata);
                pictureBox7.Visible = true;
                pictureBox7.Image = Image.FromFile("back.jpg");
            }
            if (Nr_Carti == 4)
            {
                pictureBox7.Visible = true;
                pictureBox7.Image = Image.FromFile(Carte_Generata);
                pictureBox8.Visible = true;
                pictureBox8.Image = Image.FromFile("back.jpg");
            }
            if (Nr_Carti == 5)
            {
                pictureBox8.Visible = true;
                pictureBox8.Image = Image.FromFile(Carte_Generata);
                pictureBox9.Visible = true;
                pictureBox9.Image = Image.FromFile("back.jpg");
            }
            if (Nr_Carti == 6)
            {
                pictureBox9.Visible = true;
                pictureBox9.Image = Image.FromFile(Carte_Generata);
                pictureBox10.Visible = true;
                pictureBox10.Image = Image.FromFile("back.jpg");
            }
            if (Nr_Carti == 7)
            {
                pictureBox10.Visible = true;
                pictureBox10.Image = Image.FromFile(Carte_Generata);
                pictureBox11.Visible = true;
                pictureBox11.Image = Image.FromFile("back.jpg");
            }
            if (Nr_Carti == 8)
            {
                pictureBox11.Visible = true;
                pictureBox11.Image = Image.FromFile(Carte_Generata);
            }
            if (Scor_Player > 21)
            {
                BlackJack_Win_Dealer();
                Valoare_Generata = 0;
                Carte_Generata = "";
                Scor_Dealer = Scor_Dealer + Valoare_Carte_Dealer;
                label9.Text = Scor_Dealer.ToString();
                pictureBox3.Image = Image.FromFile(Nume_Carte_Dealer);
                pictureBox3.Visible = true;
                BlackJack_Aranjare_Carti();
            }
        }

        public void BlackJack_STANDD()
        {
            Scor_Dealer = Scor_Dealer + Valoare_Carte_Dealer;
            label9.Text = Scor_Dealer.ToString();
            pictureBox3.Image = Image.FromFile(Nume_Carte_Dealer);
            pictureBox3.Visible = true;
            if (Scor_Dealer > 21)
            {
                BlackJack_Win_Player();
                BlackJack_Aranjare_Carti();
            }
            else
            {
                if (Scor_Dealer < Scor_Player)
                {
                    BlackJack_Win_Player();
                    BlackJack_Aranjare_Carti();
                }
                else
                {
                    if (Scor_Dealer > Scor_Player)
                    {
                        BlackJack_Win_Dealer();
                        BlackJack_Aranjare_Carti();
                    }
                    else
                    {
                        BlackJack_TIE();
                        BlackJack_Aranjare_Carti();
                    }
                }
            }
            
        }

        public void BlackJack_Win_Player()
        {
            string output1 = "";
            string output2 = "";
            output1 = "L" + "\n" + "O" + "\n" + "S" + "\n" + "E" + "\n" + "R";
            output2 = "W" + "\n" + "I" + "\n" + "N" + "\n" + "N" + "\n" + "E" + "\n" + "R";
            label7.ForeColor = Color.DarkRed;
            label8.ForeColor = Color.DarkGreen;
            label7.Visible = true;
            label8.Visible = true;
            label7.Text = output1;
            label8.Text = output2;
            HIT.Enabled = false;
            STAND.Enabled = false;
            Balance_Utilizator = Balance_Utilizator + Bet_Utilizator;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
        }

        public void BlackJack_Win_Dealer()
        {
            string output1 = "";
            string output2 = "";
            output1 = "L" + "\n" + "O" + "\n" + "S" + "\n" + "E" + "\n" + "R";
            output2 = "W" + "\n" + "I" + "\n" + "N" + "\n" + "N" + "\n" + "E" + "\n" + "R";
            label7.ForeColor = Color.DarkGreen;
            label8.ForeColor = Color.DarkRed;
            label7.Visible = true;
            label8.Visible = true;
            label7.Text = output2;
            label8.Text = output1;
            HIT.Enabled = false;
            STAND.Enabled = false;
            Balance_Utilizator = Balance_Utilizator - Bet_Utilizator;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
        }

        public void BlackJack_TIE()
        {
            string output = "";
            output = "T" + "\n" + "I" + "\n" + "E";
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label7.Visible = true;
            label8.Visible = true;
            label7.Text = output;
            label8.Text = output;
            label7.Location = new Point(360, 290);
            label8.Location = new Point(423, 290);
            HIT.Enabled = false;
            STAND.Enabled = false;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
        }

        public void BlackJack_Aranjare_Carti()
        {

            if (Nr_Carti == 1)
            {
                pictureBox5.Visible = false;
                pictureBox4.Location = new Point(550, 273);
            }

            if (Nr_Carti == 2)
            {
                pictureBox6.Visible = false;
                pictureBox5.Location = new Point(599, 273);
            }
            if (Nr_Carti == 3)
            {
                pictureBox7.Visible = false;
                int Raport = 210 / Nr_Carti;
                Point Location = pictureBox4.Location;
                int Locatie_X = Location.X;
                int Locatie_Y = Location.Y;
                pictureBox5.Location = new Point(Locatie_X + 210 / 2, Locatie_Y);
                pictureBox6.Location = new Point(Locatie_X + 2 * (210 / 2), Locatie_Y);
            }
            if (Nr_Carti == 4)
            {
                pictureBox8.Visible = false;
                int Raport = 210 / Nr_Carti;
                Point Location = pictureBox4.Location;
                int Locatie_X = Location.X;
                int Locatie_Y = Location.Y;
                pictureBox5.Location = new Point(Locatie_X + 210 / 3, Locatie_Y);
                pictureBox6.Location = new Point(Locatie_X + 2 * (210 / 3), Locatie_Y);
                pictureBox7.Location = new Point(Locatie_X + 3 * (210 / 3), Locatie_Y);
            }
            if (Nr_Carti == 5)
            {
                pictureBox9.Visible = false;
                int Raport = 210 / Nr_Carti;
                Point Location = pictureBox4.Location;
                int Locatie_X = Location.X;
                int Locatie_Y = Location.Y;
                pictureBox5.Location = new Point(Locatie_X + 210 / 4, Locatie_Y);
                pictureBox6.Location = new Point(Locatie_X + 2 * (210 / 4), Locatie_Y);
                pictureBox7.Location = new Point(Locatie_X + 3 * (210 / 4), Locatie_Y);
                pictureBox8.Location = new Point(Locatie_X + 4 * (210 / 4), Locatie_Y);
            }
            if (Nr_Carti == 6)
            {
                pictureBox10.Visible = false;
                int Raport = 210 / Nr_Carti;
                Point Location = pictureBox4.Location;
                int Locatie_X = Location.X;
                int Locatie_Y = Location.Y;
                pictureBox5.Location = new Point(Locatie_X + 210 / 5, Locatie_Y);
                pictureBox6.Location = new Point(Locatie_X + 2 * (210 / 5), Locatie_Y);
                pictureBox7.Location = new Point(Locatie_X + 3 * (210 / 5), Locatie_Y);
                pictureBox8.Location = new Point(Locatie_X + 4 * (210 / 5), Locatie_Y);
                pictureBox9.Location = new Point(Locatie_X + 5 * (210 / 5), Locatie_Y);
            }
            if (Nr_Carti == 7)
            {
                pictureBox11.Visible = false;
                int Raport = 210 / Nr_Carti;
                Point Location = pictureBox4.Location;
                int Locatie_X = Location.X;
                int Locatie_Y = Location.Y;
                pictureBox5.Location = new Point(Locatie_X + 210 / 6, Locatie_Y);
                pictureBox6.Location = new Point(Locatie_X + 2 * (210 / 6), Locatie_Y);
                pictureBox7.Location = new Point(Locatie_X + 3 * (210 / 6), Locatie_Y);
                pictureBox8.Location = new Point(Locatie_X + 4 * (210 / 6), Locatie_Y);
                pictureBox9.Location = new Point(Locatie_X + 5 * (210 / 6), Locatie_Y);
                pictureBox10.Location = new Point(Locatie_X + 6 * (210 / 6), Locatie_Y);
            }
            if (Nr_Carti == 8)
            {
                int Raport = 210 / Nr_Carti;
                Point Location = pictureBox4.Location;
                int Locatie_X = Location.X;
                int Locatie_Y = Location.Y;
                pictureBox5.Location = new Point(Locatie_X + 210 / 7, Locatie_Y);
                pictureBox6.Location = new Point(Locatie_X + 2 * (210 / 7), Locatie_Y);
                pictureBox7.Location = new Point(Locatie_X + 3 * (210 / 7), Locatie_Y);
                pictureBox8.Location = new Point(Locatie_X + 4 * (210 / 7), Locatie_Y);
                pictureBox9.Location = new Point(Locatie_X + 5 * (210 / 7), Locatie_Y);
                pictureBox10.Location = new Point(Locatie_X + 6 * (210 / 7), Locatie_Y);
                pictureBox11.Location = new Point(Locatie_X + 7 * (210 / 7), Locatie_Y);
            }
        }

        public BlackJack()
        {
            InitializeComponent();
        }

        public BlackJack(ref decimal Total_Balance,ref decimal Suma_Pariata, string Id_Actual , string Avatar)
        {
            InitializeComponent();
            Balance_Utilizator = Total_Balance;
            Bet_Utilizator = Suma_Pariata;
            Id_Utilizator = Id_Actual;
            Avatar_Utilizator = Avatar;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            for (int i = 0; i <= 14; ++i)
            {
                Carti adaugare = new Carti(i);
                Date.Add(adaugare);
            }
            BlackJack_Start_Joc_BlackJack(ref Scor_Dealer, ref Scor_Player);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucatoriDataSet6.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.jucatoriDataSet6.Inregistrari);

        }

        private void HIT_Click(object sender, EventArgs e)
        {
            BlackJack_HITT();
        }

        private void STAND_Click(object sender, EventArgs e)
        {
            BlackJack_STANDD();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Close();
            BlackJack_Bet BJBET = new BlackJack_Bet(ref Balance_Utilizator, Id_Utilizator, ref Avatar_Utilizator);
            BJBET.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();
            Casino Home = new Casino(ref Balance_Utilizator, ref Avatar_Utilizator, Id_Utilizator,ref Inregistrari);
            Home.Show();
        }
    }
}
