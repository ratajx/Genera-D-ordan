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

namespace General
{
    public partial class Form1 : Form
    {
        string[] tabRang;

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
            tabRang = null;

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
                dataGridView1.Rows[i].Cells[0].Value = tabRang[Convert.ToInt16(dataGridView1.Rows[i].Cells[4].Value) - 1];
        }

        void wyswietlZolnierzy()
        {
            // database accessible to your system.
            String connectionString =
                "Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8";
            string query =
            "SELECT IDZolnierza, Imię, Nazwisko, IDRangi, DataUrodzenia,GrupaKrwi, Płec, Waga, Wzrost, Zolnierz.IDBazy From Zolnierz JOIN Bazy ON Zolnierz.IDBazy=Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "'";
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);

            // Create a command builder to generate SQL update, insert, and 
            // delete commands based on selectCommand. These are used to 
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

            // Resize the DataGridView columns to fit the newly loaded content.
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns["Ra"].DisplayIndex = 1;
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Ra", "Ranga");
            
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iloscZolnierzyLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='"+ comboBox1.Text+"'"));
            iloscZolnierzyUzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "' AND Zolnierz.Wuzyciu = 'false'"));
            iloscZolnierzyNieuzytychLabel.Text = Convert.ToString(policzRekordyWarunek("Zolnierz", "JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text + "' AND Zolnierz.Wuzyciu = 'true'"));
            iloscZolnierzyZUprLabel.Text = Convert.ToString(policzRekordyWarunek("UprawnieniaTab", "JOIN Zolnierz ON Zolnierz.IDZolnierza = UprawnieniaTab.IDZolnierza JOIN Bazy ON Zolnierz.IDBazy = Bazy.IDBazy WHERE Bazy.Miasto='" + comboBox1.Text+ "'"));
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            ranga();
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyswietlZolnierzy();
            ranga();
        }



     
    }
}
