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
    public partial class addVeh : Form
    {
        globalString connString;
        public addVeh(globalString str)
        {
            InitializeComponent();
            connString = str;
        }

        void dodaj()
        {
            int baza = comboBox2.SelectedIndex+1;
            string stmt = @"insert into PojazdySpis(NazwaPojazdu, NumerRejestracyjny, RokProdukcji, IDBazy, Wuzyciu) values ('"+ comboBox1.Text +"','"+textBox1.Text+"','"+ textBox2.Text+"','"+baza+"','false')";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }

            var pr = Application.OpenForms.OfType<Form1>().Single();
            if (pr.Label9 == "Baza " + comboBox2.Text)
                pr.Veh(false);
            if (pr.Label9 == "Wszystkie bazy")
                pr.Veh(true);
            this.Close();
        }

        private void addVeh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.PojazdyTyp' table. You can move, or remove it, as needed.
            this.pojazdyTypTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.PojazdyTyp);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Bazy);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.PojazdySpis' table. You can move, or remove it, as needed.
            this.pojazdySpisTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.PojazdySpis);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodaj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
