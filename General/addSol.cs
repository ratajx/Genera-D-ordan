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
    public partial class addSol : Form
    {
        globalString connString;
        public addSol(globalString str)
        {
            InitializeComponent();
            connString = str;
        }

        void dodaj()
        {
            int IDb = comboBox3.SelectedIndex + 1;
            int IDr = comboBox2.SelectedIndex + 1;
            if(textBox1.Text!="" && textBox2.Text!="")
            {
            string stmt = @"
            insert into Zolnierz
            (Imię, Nazwisko, IDRangi, DataUrodzenia, GrupaKrwi, Płec, Waga, Wzrost, IDBazy)
            values ('"+textBox1.Text+"','"+textBox2.Text+"','"+IDr+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+comboBox1.Text+"','"+comboBox5.Text[0] +"','"+trackBar1.Value.ToString()+"','"+trackBar2.Value.ToString()+"','"+IDb+"')";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }
            MessageBox.Show(comboBox2.Text + " " + textBox1.Text + " " + textBox2.Text + " dodany do bazy danych");
            ////////////////////////^^^dodawanie zolnierza
            int ID; 
            int IDKat = comboBox4.SelectedIndex+1;
            string stmt2 = "SELECT MAX(IDZolnierza) FROM Zolnierz";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt2, thisConnection))
                {
                    thisConnection.Open();
                    ID = (int)query.ExecuteScalar();
                    thisConnection.Close();
                }
            }

            string stmt3 = @"
            insert into UprawnieniaTab
            (IDKatUprawnienia, IDZolnierza, DataNabycia, DataWaznosci)
            values('" + IDKat + "','" + ID + "','" + dateTimePicker3.Value.ToString("yyyy") + "','" + dateTimePicker2.Value.ToString("yyyy") + "')";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt3, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }



            ////////////////////////^^^dodawanie uprawnien
            login a = new login();
            Form1 ff = new Form1(connString, a);
            var pr = Application.OpenForms.OfType<Form1>().Single();
            pr.flag = false;
            if ("Baza "+comboBox3.Text == ff.Label9 || ff.Label9 == "Wszystkie bazy")
            {
                object sen = new object();
                DataGridViewCellEventArgs f = new DataGridViewCellEventArgs(0, 0);
                pr.dataGridView1_CellContentClick(sen, f);
            }
            this.Close();    
                
                
            }
            else
              MessageBox.Show("Uzupełnij wszystkie dane!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodaj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyKat' table. You can move, or remove it, as needed.
            this.pojazdyKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyKat);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Bazy);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Rangi' table. You can move, or remove it, as needed.
            this.rangiTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Rangi);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar2, trackBar2.Value.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

       




        
    }
}
