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

        string[] tabRang;
        string[] tabBaz;
        globalString connString;


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

        void downloadRang()
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

        void downloadBaz()
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

           foreach (DataGridViewColumn c in dataGridView1.Columns)
           {
               c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           }

        }

        void baza()
        {
            downloadBaz();

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Ba"].Value = tabBaz[(int)(row.Cells["IDBazy"].Value) - 1];
            }
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        void wyswietlPojazdy()
        {
            string query =
                "SELECT IDPojazdu, NazwaPojazdu, NumerRejestracyjny, RokProdukcji,PojazdySpis.IDBazy FROM PojazdySpis JOIN Bazy ON PojazdySpis.IDBazy=Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;

            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        
        public Form1(globalString str)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Status: OK.";
            connString = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter1.Fill(this.dB_9BA4F7_dzordanDataSet1.Bazy);
           // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Bazy' table. You can move, or remove it, as needed.
            //.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Bazy);

        }
  
        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            iloscZolnierzyLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='"+ comboBox1.Text+"'"));
            iloscZolnierzyUzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "' AND Zolnierz.Wuzyciu = 'false'"));
            iloscZolnierzyNieuzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "' AND Zolnierz.Wuzyciu = 'true'"));
            iloscZolnierzyZUprLabel.Text = Convert.ToString(policzRekordyWarunek("UprawnieniaTab", "JOIN Zolnierz ON Zolnierz.IDZolnierza = UprawnieniaTab.IDZolnierza JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text+ "'"));

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

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            ranga();
            if (label9.Text == "Wszystkie bazy")
                baza();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "Wszystkie bazy")
            {
                dataGridView1.Columns.Clear();
                wyswietlZolnierzy(true);
                ranga();
                dataGridView1.Width = 827;
            }
            else
                MessageBox.Show("Wybierz bazę z panelu głównego");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Columns.Count == 0)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Szczegóły";
                buttonColumn.Name = "szcz";
                buttonColumn.Text = "Wyświetl";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(buttonColumn);
                
            }
            wyswietlPojazdy();
            dataGridView2.Columns[0].DisplayIndex = 5;
            dataGridView2.Columns[5].Visible = false;
                       
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pojazd_sz pojazd = new pojazd_sz(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
            pojazd.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            pojazd.Show();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = "Wszystkie bazy";
            dataGridView1.Columns.Clear();
            wyswietlZolnierzy(false);
            ranga();
            dataGridView1.Columns.Add("Ba", "Baza");
            dataGridView1.Columns["Ba"].DisplayIndex = 10;
            baza();
            dataGridView1.Width = 894;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSol form = new addSol(connString);
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addVeh form = new addVeh(connString);
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addMan form = new addMan(connString);
            form.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addMod form = new addMod(connString);
            form.Show();
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
            }
            else
            {
                editSol editSol = new editSol();
                editSol.Show();
            }

            if (label9.Text == "Wszystkie bazy")
                button6_Click(sender, e);
            else
                button1_Click(sender, e);
                    //connString.conectionString
        }
    }
}
