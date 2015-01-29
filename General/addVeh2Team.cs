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
    public partial class addVeh2Team : Form
    {
        string connString;
        int IDskladu;
        int RowPojazd;
        int ColPojazdu;
        int IDskladu1;
        int RowPojazd1;
        int ColPojazdu1;
        public addVeh2Team(globalString str)
        {
            InitializeComponent();
            connString = str.Name;
        }

        private void addVeh2Team_Load(object sender, EventArgs e)
        {
            this.skladTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Sklad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT DISTINCT PojazdySpis.IDPojazdu, PojazdySpis.NazwaPojazdu, PojazdySpis.NumerRejestracyjny 
                            From PojazdySpis 
                           join PojazdyTyp on PojazdyTyp.NazwaPojazdu = PojazdySpis.NazwaPojazdu
                           join PojazdyKat on PojazdyKat.IDKatPojazdu = PojazdyTyp.IDKatPojazdu
                           join UprawnieniaTab on UprawnieniaTab.IDKatUprawnienia = PojazdyKat.IDKatPojazdu
                           join Zolnierz on Zolnierz.IDZolnierza = UprawnieniaTab.IDZolnierza
                           join Sklad on Sklad.IDSkladu = Zolnierz.IDSkładu
                           where Sklad.IDSkladu = '" + IDskladu + "' and PojazdySpis.IDBazy = Zolnierz.IDBazy and PojazdySpis.Wuzyciu = 'false' order by IDPojazdu";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDskladu = e.RowIndex+1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDskladu = e.RowIndex+1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IDVeh = dataGridView2.Rows[RowPojazd].Cells[ColPojazdu].Value.ToString();

            string update = @"
             update PojazdySpis
             set IDSkładu='" + IDskladu + "', Wuzyciu='true' where IDPojazdu='"+IDVeh+"'";

            using (SqlConnection thisConnection = new SqlConnection(connString))
            {
                using (SqlCommand query = new SqlCommand(update, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Zaktualizowano");
            this.Close();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowPojazd = e.RowIndex;
            ColPojazdu = e.ColumnIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"SELECT DISTINCT PojazdySpis.IDPojazdu, PojazdySpis.NazwaPojazdu, PojazdySpis.NumerRejestracyjny 
                            From PojazdySpis 
                           join PojazdyTyp on PojazdyTyp.NazwaPojazdu = PojazdySpis.NazwaPojazdu
                           join PojazdyKat on PojazdyKat.IDKatPojazdu = PojazdyTyp.IDKatPojazdu
                           join UprawnieniaTab on UprawnieniaTab.IDKatUprawnienia = PojazdyKat.IDKatPojazdu
                           join Zolnierz on Zolnierz.IDZolnierza = UprawnieniaTab.IDZolnierza
                           join Sklad on Sklad.IDSkladu = Zolnierz.IDSkładu
                           where Sklad.IDSkladu = '"+IDskladu1+"' and PojazdySpis.IDBazy = Zolnierz.IDBazy and PojazdySpis.Wuzyciu = 'true' order by IDPojazdu";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView4.DataSource = table;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDskladu1 = e.RowIndex + 1;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowPojazd1 = e.RowIndex;
            ColPojazdu1 = e.ColumnIndex;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string IDVeh = dataGridView4.Rows[RowPojazd1].Cells[ColPojazdu1].Value.ToString();

            string update = @"
             update PojazdySpis
             set IDSkładu='" + IDskladu1 + "', Wuzyciu='true' where IDPojazdu='" + IDVeh + "'";

            using (SqlConnection thisConnection = new SqlConnection(connString))
            {
                using (SqlCommand query = new SqlCommand(update, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Zaktualizowano");
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDskladu1 = e.RowIndex + 1;
        }
    }
}
