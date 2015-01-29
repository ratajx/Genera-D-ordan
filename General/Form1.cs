using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;


namespace General
{
    public partial class Form1 : Form
    {

        public string[] tabRang;
        public string[] tabBaz;
        public string[] tabMan;
        public string[] tabSk;

        globalString connString;

        public string Label9
        {
            get{return this.label9.Text;}
            set{this.label9.Text = value;}
        }

        public string Label59
        {
            get { return this.label59.Text; }
            set { this.label59.Text = value; }
        }

        public string Label60
        {
            get { return this.label60.Text; }
            set { this.label60.Text = value; }
        }

        public void baseDetails(bool all)
        {
            if (all)
            {
                iloscZolnierzyLabel.Text = Convert.ToString(policzRekordy("Zolnierz"));
                iloscZolnierzyUzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "WHERE Wuzyciu = 'false'"));
                iloscZolnierzyNieuzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "WHERE Wuzyciu = 'true'"));
                iloscZolnierzyZUprLabel.Text = Convert.ToString(policzRekordy("UprawnieniaTab"));
                iloscSkaldowLabel.Text = Convert.ToString(policzRekordy("Sklad"));
                iloscPojazdowLabel.Text = Convert.ToString(policzRekordy("PojazdySpis"));
                iloscPojazdowUzytychLabel.Text = Convert.ToString(policzRekordyWarunek("PojazdySpis", "WHERE Wuzyciu = 'false'"));
                iloscPojazdowNiezytychLabel.Text = Convert.ToString(policzRekordyWarunek("PojazdySpis", "WHERE Wuzyciu = 'true'"));

                label33.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 1 + "'"));
                label34.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 2 + "'"));
                label35.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 3 + "'"));
                label36.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 4 + "'"));
                label37.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 5 + "'"));
                label38.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 6 + "'"));
                label39.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 7 + "'"));
                label40.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 8 + "'"));
                label43.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 9 + "'"));
                label44.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 10 + "'"));
                label45.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 11 + "'"));
                label46.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 12 + "'"));
                label47.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 13 + "'"));
                label48.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 14 + "'"));
                label51.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 15 + "'"));
                label52.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 16 + "'"));
                label53.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 17 + "'"));
                label54.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 18 + "'"));
                label55.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 19 + "'"));
                label56.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 20 + "'"));
                label57.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 21 + "'"));
                label58.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 22 + "'"));
            }
            else
            {
                iloscZolnierzyLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'"));
                iloscZolnierzyUzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "' AND Zolnierz.Wuzyciu = 'false'"));
                iloscZolnierzyNieuzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "' AND Zolnierz.Wuzyciu = 'true'"));
                iloscZolnierzyZUprLabel.Text = Convert.ToString(policzRekordyWarunek("UprawnieniaTab", "JOIN Zolnierz ON Zolnierz.IDZolnierza = UprawnieniaTab.IDZolnierza JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'"));

                iloscSkaldowLabel.Text = (Convert.ToString(policzRekordyWarunek("Sklad", "JOIN Zolnierz ON Zolnierz.IDSkładu = Sklad.IDSkladu JOIN Bazy ON Bazy.IDBazy = Zolnierz.IDBazy WHERE Bazy.Miasto='Poznań'")));
                iloscPojazdowUzytychLabel.Text = Convert.ToString(policzRekordyWarunek("PojazdySpis", "JOIN Bazy ON PojazdySpis.IDBazy = Bazy.IDBazy WHERE Wuzyciu = 'false' AND Bazy.Miasto='" + comboBox1.Text + "'"));
                iloscPojazdowNiezytychLabel.Text = Convert.ToString(policzRekordyWarunek("PojazdySpis", "JOIN Bazy ON PojazdySpis.IDBazy = Bazy.IDBazy WHERE Wuzyciu = 'true' AND Bazy.Miasto='" + comboBox1.Text + "'"));

                label33.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 1 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label34.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 2 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label35.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 3 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label36.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 4 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label37.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 5 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label38.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 6 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label39.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 7 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label40.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 8 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label43.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 9 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label44.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 10 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label45.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 11 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label46.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 12 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label47.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 13 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label48.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 14 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label51.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 15 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label52.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 16 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label53.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 17 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label54.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 18 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label55.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 19 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label56.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 20 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label57.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 21 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
                label58.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Zolnierz.IDRangi = '" + 22 + "' AND Bazy.Miasto = '" + comboBox1.Text + "'"));
        
            }
        }

        public void Veh(bool all)
        {
            if (all)
            {
                label59.Text = "Wszystkie bazy";
                dataGridView2.Columns.Clear();
                wyswietlPojazdy(false);
                dataGridView2.Columns.Add("Ba", "Baza");
                baza(dataGridView2);
                dataGridView2.Columns["Ba"].DisplayIndex = 5;
                dataGridView2.Width = width(dataGridView2);
            }
            else
            {
                if (label59.Text != "Wszystkie bazy")
                {
                    dataGridView2.Columns.Clear();
                    wyswietlPojazdy(true);
                    dataGridView2.Width = width(dataGridView2);
                }
                else
                    MessageBox.Show("Wybierz bazę z panelu głównego");
            }
        }

        public void Bas(bool all)
        {
            if (all)
            {
                label9.Text = "Wszystkie bazy";
                dataGridView1.Columns.Clear();
                wyswietlZolnierzy(false);
                ranga();
                dataGridView1.Columns.Add("Ba", "Baza");
                dataGridView1.Columns["Ba"].DisplayIndex = 10;
                baza(dataGridView1);
                setWidthSol(true);
                dataGridView1.Width = width(dataGridView1);
            }
            else
            {
                if (label9.Text != "Wszystkie bazy")
                {
                    dataGridView1.Columns.Clear();
                    wyswietlZolnierzy(true);
                    ranga();
                    setWidthSol(false);
                    dataGridView1.Width = width(dataGridView1);
                }
                else
                    MessageBox.Show("Wybierz bazę z panelu głównego");
            }
        }

        public void Man(bool all)
        {
            if (all)
            {
                label60.Text = "Wszystkie bazy";
                dataGridView3.Columns.Clear();
                wyswietlManewry(true);
                manewr();
                dataGridView3.Columns.Add("Ba", "Baza");
                dataGridView3.Columns["Ba"].DisplayIndex = 7;
                baza(dataGridView3);
                sklad();
                setWidthMan(true);
                dataGridView3.Width = width(dataGridView3)-18;
            }
            else
            {
                if (label60.Text != "Wszystkie bazy")
                {
                    dataGridView3.Columns.Clear();
                    wyswietlManewry(false);
                    manewr();
                    sklad();
                    setWidthMan(false);
                    dataGridView3.Width = width(dataGridView3)-18;
                }
                else
                    MessageBox.Show("Wybierz bazę z panelu głównego");
            }
        }

        private void setWidthSol(bool baza)
        {
            dataGridView1.Columns[1].Width = 35;
            dataGridView1.Columns[2].Width = 78;
            dataGridView1.Columns[3].Width = 85;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 38;
            dataGridView1.Columns[7].Width = 32;
            dataGridView1.Columns[8].Width = 38;
            dataGridView1.Columns[9].Width = 42;
            if(baza)
            dataGridView1.Columns["Ba"].Width = 65;
            dataGridView1.Columns[11].Width = 40;
            dataGridView1.Columns[12].Width = 40;
        }

        private void setWidthMan(bool baza)
        {
            dataGridView3.Columns[0].Width = 30;
            dataGridView3.Columns["Kat"].Width = 80;
            dataGridView3.Columns["Sk"].Width = 100;
            dataGridView3.Columns[3].Width = 75;
            dataGridView3.Columns[4].Width = 75;
            dataGridView3.Columns[5].Width = 55;
            if (baza)
                dataGridView3.Columns["Ba"].Width = 65;
            dataGridView3.Columns[8].Width = 45;
            dataGridView3.Columns[9].Width = 40;
            dataGridView3.Columns[10].Width = 40;
        }

        public int width(DataGridView d)
        {
            int w = 0;
            for(int i=0;i<d.Columns.Count;i++)
                if(d.Columns[i].Visible==true)
                    w+=d.Columns[i].Width;

            return w+61;
        }
       
        public int policzRekordy(string nazwaTabeli)
        {
            string stmt = "SELECT COUNT (*) FROM " + nazwaTabeli;
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                    
                }
                return count;
            }
        }

        public int policzRekordyWarunek(string nazwaTabeli, string warunek)
        {
 
            string stmt = "SELECT COUNT (*) FROM "+nazwaTabeli+ " " + warunek;
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            return count;
        }

        public void downloadRang()
        {
            string stmt = "SELECT COUNT (*) FROM Rangi" ;
            string stmt1 = "SELECT NazwaRangi FROM Rangi";
            SqlDataReader rdr = null;
            int i=0,count = 0;
            tabRang = null;

            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    
                    count = (int)cmdCount.ExecuteScalar();
                    cmdCount.CommandText = stmt1;
                    
                    rdr = cmdCount.ExecuteReader();
                   
                    tabRang=new string[count];
                    while(rdr.Read())
                    {
                     tabRang[i]= (string)rdr["NazwaRangi"];
                     i++;
                    }
                    thisConnection.Close();
                }
            }          

        }

        public void downloadBaz()
        {
            string stmt = "SELECT COUNT (*) FROM Bazy";
            string stmt1 = "SELECT Miasto FROM Bazy";
            SqlDataReader rdr = null;
            int i = 0, count = 0;
            tabBaz = null;

            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();

                    count = (int)cmdCount.ExecuteScalar();
                    cmdCount.CommandText = stmt1;

                    rdr = cmdCount.ExecuteReader();

                    tabBaz = new string[count];
                    while (rdr.Read())
                    {
                        tabBaz[i] = (string)rdr["Miasto"];
                        i++;
                    }
                    thisConnection.Close();
                }
            }
        }

        public void downloadMan()
       {
           string stmt = "SELECT COUNT (*) FROM ManewryKat";
           string stmt1 = "SELECT Nazwa FROM ManewryKat";
           SqlDataReader rdr = null;
           int i = 0, count = 0;
           tabMan = null;

           using (SqlConnection thisConnection = new SqlConnection(connString.Name))
           {
               using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
               {
                   thisConnection.Open();

                   count = (int)cmdCount.ExecuteScalar();
                   cmdCount.CommandText = stmt1;

                   rdr = cmdCount.ExecuteReader();

                   tabMan = new string[count];
                   while (rdr.Read())
                   {
                       tabMan[i] = (string)rdr["Nazwa"];
                       i++;
                   }
                   thisConnection.Close();
               }
           }          
       }

        public void downloadSk()
        {
            string stmt = "SELECT COUNT (*) FROM Sklad";
            string stmt1 = "SELECT Nazwa FROM Sklad";
            SqlDataReader rdr = null;
            int i = 0, count = 0;
            tabSk = null;

            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();

                    count = (int)cmdCount.ExecuteScalar();
                    cmdCount.CommandText = stmt1;

                    rdr = cmdCount.ExecuteReader();

                    tabSk = new string[count];
                    while (rdr.Read())
                    {
                        tabSk[i] = (string)rdr["Nazwa"];
                        i++;
                    }
                    thisConnection.Close();
                }
            }
        }

        void ranga()
        {
            downloadRang();
           foreach (DataGridViewColumn c in dataGridView1.Columns)
           {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
           }
           foreach (DataGridViewRow row in dataGridView1.Rows)
           {
             row.Cells[0].Value = tabRang[(int)(row.Cells[4].Value) - 1];
           }
        }

        void baza(DataGridView d)
        {
            downloadBaz();

            foreach (DataGridViewColumn c in d.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            foreach (DataGridViewRow row in d.Rows)
            {
                row.Cells["Ba"].Value = tabBaz[(int)(row.Cells["IDBazy"].Value) - 1];
            }
        }

        void manewr()
        {
            downloadMan();
            foreach (DataGridViewColumn c in dataGridView3.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.Cells["Kat"].Value = tabMan[(int)(row.Cells[1].Value) - 1];
            }
        }

        void sklad()
        {
            downloadSk();
            foreach (DataGridViewColumn c in dataGridView3.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.Cells["Sk"].Value = tabSk[(int)(row.Cells[5].Value) - 1];
            }
        }

        void wyswietlZolnierzy(bool baza)
        {
            string query;
            if (baza)
                query = "SELECT IDZolnierza, Imię, Nazwisko, IDRangi, DataUrodzenia,GrupaKrwi, Płec, Waga, Wzrost, Zolnierz.IDBazy From Zolnierz JOIN Bazy ON Zolnierz.IDBazy=Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'";
            else
                query = "SELECT IDZolnierza, Imię, Nazwisko, IDRangi, DataUrodzenia,GrupaKrwi, Płec, Waga, Wzrost, Zolnierz.IDBazy From Zolnierz";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.Columns.Add("Ra", "Ranga");
            dataGridView1.DataSource = table;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns["Ra"].DisplayIndex = 1;
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[5].HeaderText = "Data urodzenia";
            dataGridView1.Columns[6].HeaderText = "Grupa Krwi";
            
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "delet";
            buttonColumn.Text = "Usuń";
            buttonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "";
            buttonColumn1.Name = "edit";
            buttonColumn1.Text = "Edytuj";
            buttonColumn1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn1);
            dataGridView1.Columns.Add(buttonColumn);
        }

        void wyswietlPojazdy(bool pojazd)
        {
            string query;
            if(pojazd)
               query= "SELECT IDPojazdu, NazwaPojazdu, NumerRejestracyjny, RokProdukcji,PojazdySpis.IDBazy FROM PojazdySpis JOIN Bazy ON PojazdySpis.IDBazy=Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'";
            else
                query = "SELECT IDPojazdu, NazwaPojazdu, NumerRejestracyjny, RokProdukcji,PojazdySpis.IDBazy FROM PojazdySpis";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;

            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[4].Visible = false;
           
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Szczegóły";
            buttonColumn.Name = "szcz";
            buttonColumn.Text = "Wyświetl";
            buttonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "";
            buttonColumn1.Name = "delet";
            buttonColumn1.Text = "Usuń";
            buttonColumn1.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "";
            buttonColumn2.Name = "edit";
            buttonColumn2.Text = "Edytuj";
            buttonColumn2.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(buttonColumn);
            dataGridView2.Columns.Add(buttonColumn2);
            dataGridView2.Columns.Add(buttonColumn1);

            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        void wyswietlManewry(bool manewr)
        {
            string query;
            if (manewr) 
                query = "SELECT IDManewryTab,IDManewryKat,IDBazy,DataOd,DataDo,IDSkładu From ManewryTab";
            else
                query = "SELECT IDManewryTab,IDManewryKat,ManewryTab.IDBazy,DataOd,DataDo,IDSkładu From ManewryTab JOIN Bazy ON ManewryTab.IDBazy=Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView3.DataSource = table;

            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[5].Visible = false;

            dataGridView3.Columns.Add("Kat", "Kategoria");
            dataGridView3.Columns["Kat"].DisplayIndex = 2;

            dataGridView3.Columns.Add("Sk", "Skład");
            dataGridView3.Columns["Sk"].DisplayIndex = 1;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Skład";
            buttonColumn.Name = "szcz";
            buttonColumn.Text = "Wyświetl";
            buttonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "";
            buttonColumn1.Name = "delet";
            buttonColumn1.Text = "Usuń";
            buttonColumn1.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "";
            buttonColumn2.Name = "edit";
            buttonColumn2.Text = "Edytuj";
            buttonColumn2.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(buttonColumn);
            dataGridView3.Columns.Add(buttonColumn2);
            dataGridView3.Columns.Add(buttonColumn1);

        }

        public Form1(globalString str, Form login)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Status: OK.";
            connString = str;
            login.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bazyTableAdapter1.Fill(this.dB_9BA4F7_dzordanDataSet1.Bazy);
        }
  
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            ranga();
            if (label9.Text == "Wszystkie bazy")
                baza(dataGridView1);
        }
       
        private void dataGridView2_Sorted(object sender, EventArgs e)
        {
            if (label59.Text == "Wszystkie bazy")
                baza(dataGridView2);
        }
       
        private void dataGridView3_Sorted(object sender, EventArgs e)
        {
            manewr();
            if (label60.Text == "Wszystkie bazy")
                baza(dataGridView3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = "Baza " + comboBox1.Text;
            label59.Text = "Baza " + comboBox1.Text;
            label60.Text = "Baza " + comboBox1.Text;
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
        }
        
        //PANEL GŁÓWNY
        private void button3_Click(object sender, EventArgs e)
        {
            baseDetails(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baseDetails(false);
        }
       
        //ŻOŁNIERZE
        private void button1_Click(object sender, EventArgs e)
        {
            Bas(false);
        }     
        
        private void button6_Click(object sender, EventArgs e)
        {
            Bas(true);
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            addSol form = new addSol(connString);
            form.Show();
        }
       
        //POJAZDY
        private void button7_Click(object sender, EventArgs e)
        {
            Veh(false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Veh(true);
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            addVeh form = new addVeh(connString);
            form.Show();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            addMod form = new addMod(connString);
            form.Show();
        }

        //MANEWRY
        private void button12_Click(object sender, EventArgs e)
        {
            addMan form = new addMan(connString);
            form.Show();
        }
 
        private void button11_Click(object sender, EventArgs e)
        {
            Man(false);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Man(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.ColumnIndex == 12)
                {
                    string stmt = @"
                    delete from Zolnierz
                    where IDZolnierza = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";

                    using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
                    {
                        using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                        {
                            thisConnection.Open();
                            query.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Usunięto");

                    if (label9.Text == "Wszystkie bazy")
                        Bas(true);
                    else
                        Bas(false);
                }
                if(e.ColumnIndex == 11)
                {
                    DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                    editSol editSol = new editSol(connString, r);
                    editSol.Show();
                }       
        }
       
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                pojazd_sz pojazd = new pojazd_sz(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(), connString);
                pojazd.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                pojazd.Show();
            }
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow r = dataGridView2.Rows[e.RowIndex];
                editVeh editVeh = new editVeh(connString,r);
                editVeh.Show();
            }
            if (e.ColumnIndex == 7)
            {
                string stmt = @"
            delete from PojazdySpis
            where IDPojazdu = '" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";

                using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
                {
                    using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                    {
                        thisConnection.Open();
                        query.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usunięto");

                if (label9.Text == "Wszystkie bazy")
                    Veh(true);
                else
                    Veh(false);
            }      

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                sklad sklad = new sklad(connString,dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString());
                sklad.Show();
            }
            if (e.ColumnIndex == 9)
            {
                DataGridViewRow r = dataGridView3.Rows[e.RowIndex];
                editMan edit = new editMan(connString,r);
                edit.Show();
            }
            if (e.ColumnIndex == 10)
            {
                string stmt = @"
                delete from ManewryTab
                where IDManewryTab = '" + dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";

                using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
                {
                    using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                    {
                        thisConnection.Open();
                        query.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usunięto");

                if (label60.Text == "Wszystkie bazy")
                    Man(true);
                else
                    Man(false);
            }      
        }


    }
}
