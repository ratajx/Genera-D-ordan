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
using General;


namespace General
{
    public partial class addMod : Form
    {

        public addMod()
        {
            InitializeComponent();
        }

        void dodaj()
        {
            if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " ")
            {
                int kat = comboBox1.SelectedIndex + 1;
                string stmt = @"insert into PojazdyTyp(NazwaPojazdu, IDKatPojazdu, Masa, Ładowność) values ('" + textBox1.Text + "','" + kat + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
                {
                    using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                    {
                        thisConnection.Open();
                        query.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("Uzupełnij wszystkie dane!");
        }


        private void addMod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyKat' table. You can move, or remove it, as needed.
            this.pojazdyKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyKat);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyTyp' table. You can move, or remove it, as needed.
            this.pojazdyTypTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyTyp);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodaj();
        }
    }
}