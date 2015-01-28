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
    public partial class addMan : Form
    {
        globalString connString;
        public addMan(globalString str)
        {
            InitializeComponent();
            connString = str;
        }

        private void addMan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.ManewryKat' table. You can move, or remove it, as needed.
            this.manewryKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.ManewryKat);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.Sklad' table. You can move, or remove it, as needed.
            this.skladTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Sklad);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Bazy);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyKat' table. You can move, or remove it, as needed.
            this.pojazdyKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyKat);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDs = comboBox3.SelectedIndex + 1;
            string query = "SELECT Imię, Nazwisko from Zolnierz where Zolnierz.IDSkładu = '" + IDs + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;
 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDb = comboBox2.SelectedIndex + 1;
            string query = "SELECT IDPojazdu, NazwaPojazdu, NumerRejestracyjny From PojazdySpis join PojazdyTyp on PojazdyTyp.NazwaPojazdu = PojazdySpis.NazwaPojazdu join PojazdyKat on PojazdyKat.IDKatPojazdu = PojazdyTyp.IDKatPojazdu join UprawnieniaTab on UprawnieniaTab.IDKatUprawnienia = PojazdyKat.IDKatPojazdu join Zolnierz on UprawnieniaTab.IDZolnierza = Zolnierz.IDZolnierza WHERE Zolnierz.IDBazy='" + IDb + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
