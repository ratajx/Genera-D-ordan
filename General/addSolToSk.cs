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
    public partial class addSolToSk : Form
    {
        globalString connString;
        public string[] tabRang;
        public string[] tabBaz;
        public string id;

        public addSolToSk(globalString str, string ID)
        {
            InitializeComponent();
            connString = str;
            id=ID;
            Zolnierz();
        }

        void ranga()
        {
            downloadRang();
            int i = 0;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                i=Convert.ToInt32(row.Cells[4].Value.ToString()) - 1;
           
                row.Cells[1].Value = tabRang[i];
            }
        }

        void baza(DataGridView d)
        {
            downloadBaz();
            int i=0;
            foreach (DataGridViewColumn c in d.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            foreach (DataGridViewRow row in d.Rows)
            {
                i=Convert.ToInt32(row.Cells[10].Value.ToString()) - 1;
              
                row.Cells[11].Value = tabBaz[i];
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

        public void downloadRang()
        {
            string stmt = "SELECT COUNT (*) FROM Rangi";
            string stmt1 = "SELECT NazwaRangi FROM Rangi";
            SqlDataReader rdr = null;
            int i = 0, count = 0;
            tabRang = null;

            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();

                    count = (int)cmdCount.ExecuteScalar();
                    cmdCount.CommandText = stmt1;

                    rdr = cmdCount.ExecuteReader();

                    tabRang = new string[count];
                    while (rdr.Read())
                    {
                        tabRang[i] = (string)rdr["NazwaRangi"];
                        i++;
                    }
                    thisConnection.Close();
                }
            }

        }

        public int width(DataGridView d)
        {
            int w = 0;
            for (int i = 0; i < d.Columns.Count; i++)
                if (d.Columns[i].Visible == true)
                    w += d.Columns[i].Width;

            return w + 61;
        }

        private void setWidthSol(bool baza)
        {
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 78;
            dataGridView1.Columns[2].Width = 85;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 38;
            dataGridView1.Columns[6].Width = 32;
            dataGridView1.Columns[7].Width = 38;
            dataGridView1.Columns[8].Width = 42;
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[11].Width =55;
            dataGridView1.Columns[12].Width = 45;
        
        }

        public void Zolnierz()
        {
            dataGridView1.Columns.Clear();
            wyswietl(connString);
            ranga();
            //dataGridView1.Columns.Add("Ba", "Baza");
            //dataGridView1.Columns["Ba"].DisplayIndex = 10;
           baza(dataGridView1);
            setWidthSol(true);
            //dataGridView1.Columns[0].Visible = true;
            //dataGridView1.Columns[12].Visible = true;
            dataGridView1.Width = width(dataGridView1);
        }

        public void wyswietl(globalString connString)
        {
            string query = "SELECT IDZolnierza,Imię,Imię, Nazwisko, IDRangi, DataUrodzenia,GrupaKrwi, Płec, Waga, Wzrost, Zolnierz.IDBazy,Imię From Zolnierz WHERE Zolnierz.Wuzyciu=0 AND Zolnierz.IDSkładu<>'"+id+"'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);

            //dataGridView1.Columns.Add("Ra", "Ranga");
            dataGridView1.DataSource = table;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns["Ra"].DisplayIndex = 1;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ranga";
            dataGridView1.Columns[2].HeaderText = "Imię";
            dataGridView1.Columns[11].HeaderText = "Baza";
            dataGridView1.Columns[4].HeaderText = "Data urodzenia";
            dataGridView1.Columns[5].HeaderText = "Grupa Krwi";

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "add";
            buttonColumn.Text = "Dodaj";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSolToSk_Load(object sender, EventArgs e)
        {

        }
    }
}
