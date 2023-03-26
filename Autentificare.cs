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
    class Autentificare
    {
        public int Total_Persoane = 0;

        public bool DataBase_ValidareSuma(string Bani)
        {
            string strRegex = @"^[1-9][0-9]{0,8}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Bani))
                return true;
            else
                return false;
        }

        public bool DataBase_ParolaLength(string Parola)
        {
            int Lungime = Parola.Length;
            if (Lungime >= 5)
                return true;
            else
                return false;
        }

        public bool DataBase_MatchingPassword(string Parola , string Parola_Confirm)
        {
            if(String.Compare(Parola,Parola_Confirm) == 0)
                return true;
            else
                return false;
        }

        public string DataBase_Logare(string Adresa, string Parola) //Incercare logare cu mesajul corespunzator in functie de datele introduse
        {

            bool Existenta_Cont = false;

            SqlConnection connection;
            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query;
                SqlDataReader iterator;
                String command;

                command = "Select Adresa, Parola FROM Inregistrari";
                query = new SqlCommand(command, connection);
                iterator = query.ExecuteReader();
                while (iterator.Read())
                {
                    string Adresa_Curenta = iterator.GetValue(0).ToString();
                    string Parola_Curenta = iterator.GetValue(1).ToString();
                    if (String.Compare(Adresa, Adresa_Curenta) == 0 && String.Compare(Parola, Parola_Curenta) == 0)
                        return "Login successfully!";
                    else
                    {
                        if ((String.Compare(Adresa, Adresa_Curenta) == 0 && String.Compare(Parola, Parola_Curenta) !=0)) 
                            Existenta_Cont = true;
                    }

                }
                if(Existenta_Cont == true)
                    return "Invalid mail/password!";
                else
                    return "Don't have an account?Register!";
            }
        }

        public void DataBase_Inregistrare(string Adresa , string Parola ,string Parola_Confirm, string Text_Bani ,decimal Bani, string Avatar , ref DataGridView ConturiDataGridView, ref bool Ap_Adresa , ref bool Valid_Adresa , ref bool Confirm_Parola , ref bool Valid_Suma, ref bool Valid_Lungime , ref bool Valid_Avatar)
        {
            string Id_Random = DataBase_Generare_Id();
            bool Existenta_Adresa = DataBase_Aparitie_Adresa(Adresa);
            bool Format_Adresa = DataBase_Validare_Adresa(Adresa);
            bool Matching_Parole = DataBase_MatchingPassword(Parola,Parola_Confirm);
            bool Format_Bani = DataBase_ValidareSuma(Text_Bani);
            bool Lungime_Parola = DataBase_ParolaLength(Parola);
            if (Existenta_Adresa == false && Format_Adresa == true && Matching_Parole == true && Format_Bani == true  && Lungime_Parola == true && Valid_Avatar == true)
            {
                SqlConnection connection;
                using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand("INSERT INTO Inregistrari (ID, Adresa, Parola, Bani , Avatar) VALUES (@ID, @Nume, @Parola, @Bani , @Avatar)", connection);
                    query.Parameters.Add(new SqlParameter("@ID", Id_Random));
                    query.Parameters.Add(new SqlParameter("@Nume", Adresa));
                    query.Parameters.Add(new SqlParameter("@Parola", Parola));
                    query.Parameters.Add(new SqlParameter("@Bani", Bani));
                    query.Parameters.Add(new SqlParameter("@Avatar",Avatar));
                    SqlDataAdapter adapter = new SqlDataAdapter(query);
                    DataSet new_ds = new DataSet();
                    int result = adapter.Fill(new_ds, "Inregistrari");
                    ConturiDataGridView.DataSource = new_ds.Tables["Inregistrari"];
                    Total_Persoane++;
                    connection.Close();
                }
            }
            else
            {
                if (Format_Adresa == false)
                    Valid_Adresa = false;
                if (Existenta_Adresa == true)
                        Ap_Adresa = true;
                if (Matching_Parole == false)
                        Confirm_Parola = false;
                if (Format_Bani == false)
                        Valid_Suma = false;
                if(Lungime_Parola == false)
                        Valid_Lungime = false;
            }
        }

        public string DataBase_Generare_Id() //Genenereaza un id nou distinct si random in lista de inregistrari
        {
            Random rnd = new Random();
            int Act = rnd.Next(1, 10001);
            string Id_curent = "#" + Act;
            if (Total_Persoane == 0)
            {
                Total_Persoane++;
                return Id_curent;
            }
            else
            {
                SqlConnection connection;
                using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
                {
                    connection.Open();

                    SqlCommand query;
                    SqlDataReader iterator;
                    String command;

                    command = "Select ID FROM Inregistrari";
                    query = new SqlCommand(command, connection);
                    iterator = query.ExecuteReader();
                    while (iterator.Read())
                    {
                        string output = iterator.GetValue(0).ToString();
                        if (String.Compare(output, Id_curent) == 0)
                        {
                            return DataBase_Generare_Id();
                        }
                    }
                }
                return Id_curent;
            }
        }

        public static bool DataBase_Aparitie_Adresa(string Adresa_Introdusa) //Verficarea existentei unui cont cu adresa de mail introdusa
        {
            SqlConnection connection;
            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query;
                SqlDataReader iterator;
                String command;

                command = "Select Adresa FROM Inregistrari";
                query = new SqlCommand(command, connection);
                iterator = query.ExecuteReader();
                while (iterator.Read())
                {
                    string Adresa_Curenta = iterator.GetValue(0).ToString();
                    if (String.Compare(Adresa_Introdusa, Adresa_Curenta) == 0)
                        return true;
                }
                return false;
                connection.Close();
            }
        }

        public bool DataBase_Validare_Adresa(string Adresa) //Verificare corectitudinii adresei de mail introdusa pe baza unei expreii de tip 'regular'
        {
            if (Adresa.Length == 0)
                return false;
            string strRegex = @"[a-zA-Z0-9]+@([a-z]+(\.[a-z]+))(\.[a-z])*";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Adresa))
                return true;
            else
                return false;
        }

        public void DateBase_Afisare() //Afisaza pe ecran datele introduse in 'Inregistrari' in baza de date SQL
        {
            SqlConnection connection;
            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query;
                SqlDataReader iterator;
                String command;

                command = "Select ID, Adresa, Parola, Bani FROM Inregistrari";
                query = new SqlCommand(command, connection);
                iterator = query.ExecuteReader();
                string output = "ID" + "                     " + "Adresa" + "        " + "Parola" + "     " + "Bani" + '\n' + '\n';
                while (iterator.Read())
                {
                    output = output + iterator.GetValue(0).ToString() + " " + iterator.GetValue(1).ToString() + " " + iterator.GetValue(2).ToString() + " " + iterator.GetValue(3).ToString() + " " + iterator.GetValue(4).ToString() + '\n';
                }
                MessageBox.Show(output);
                connection.Close();
            }
        }

        public void DataBase_Stergere(DataGridView ConturiDataGridView)
        {
            SqlConnection connection;
            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query = new SqlCommand(("DELETE FROM Inregistrari"), connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataSet new_ds = new DataSet();
                int result = adapter.Fill(new_ds, "Inregistrari");
                ConturiDataGridView.DataSource = new_ds.Tables["Inregistrari"];
                connection.Close();
            }
        } //Golirea tabelului 'Inregistrari' din SQL

        public void DataBase_Finder(ref decimal Suma_Bani, string Id)
        {

            SqlConnection connection;

            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query;
                SqlDataReader iterator;
                String command;

                command = "Select Bani, ID FROM Inregistrari";
                query = new SqlCommand(command, connection);
                iterator = query.ExecuteReader();

                while (iterator.Read())
                {
                    string Bani_Curent = iterator.GetValue(0).ToString();
                    string Id_Curent = iterator.GetValue(1).ToString();
                    if (String.Compare(Id, Id_Curent) == 0)
                    {
                        Suma_Bani = decimal.Parse(Bani_Curent);
                    }

                }
            }
            
        }

        public void DataBase_Eliminare(string Adresa_Jucator, DataGridView ConturiDataGridView) //Eliminare jucator dupa un anumit parametru/parametri
        {
            SqlConnection connection;
            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                string comanda = ("DELETE FROM Inregistrari WHERE Adresa = @Adr");
                SqlCommand query = new SqlCommand(comanda, connection);
                query.Parameters.Add(new SqlParameter("@Adr", Adresa_Jucator));
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataSet new_ds = new DataSet();
                int result = adapter.Fill(new_ds, "Inregistrari");
                ConturiDataGridView.DataSource = new_ds.Tables["Inregistrari"];
                connection.Close();
            }
        }

        public void DataBase_SelectarePersoana(string Adresa , string Parola , ref decimal Bani_User , ref string Avatar_User , ref string Id_User)
        {
            SqlConnection connection;

            using (connection = new SqlConnection("Server=DESKTOP-STKHQER\\SQLEXPRESS;Database=Jucatori;Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand query;
                SqlDataReader iterator;
                String command;

                command = "Select Adresa, Parola, Bani, Avatar, ID FROM Inregistrari";
                query = new SqlCommand(command, connection);
                iterator = query.ExecuteReader();

                while (iterator.Read())
                {
                    string Adresa_Curenta = iterator.GetValue(0).ToString();
                    string Parola_Curenta = iterator.GetValue(1).ToString();
                    string Bani_Curenti = iterator.GetValue(2).ToString();
                    string Avatar_Curent = iterator.GetValue(3).ToString();
                    string Id_Curent = iterator.GetValue(4).ToString();
                    if (String.Compare(Adresa, Adresa_Curenta) == 0 && String.Compare(Parola, Parola_Curenta) == 0)
                    {
                        decimal Atribuire_Bani = decimal.Parse(Bani_Curenti);
                        Bani_User = Atribuire_Bani;
                        Avatar_User = Avatar_Curent;
                        Id_User = Id_Curent;
                    }

                }

            }

        }
    }
}
