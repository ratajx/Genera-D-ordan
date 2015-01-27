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
        int x = 0;

        public int policzRekordy(string nazwaTabeli)
        {
            string stmt = "SELECT COUNT (*) FROM " + nazwaTabeli;
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
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

            using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
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


            using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
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
       
        void ranga()
        {
            downloadRang();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells[1].Value = tabRang[Convert.ToInt16(dataGridView1.Rows[i].Cells[9].Value) - 1];
        }



        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Status: OK.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Zolnierz' table. You can move, or remove it, as needed.
            this.zolnierzTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Zolnierz);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Bazy);

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
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            ranga();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            label9.Text = "dssd";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x++;
            label9.Text = Convert.ToString(x);
        }

     
    }
}
