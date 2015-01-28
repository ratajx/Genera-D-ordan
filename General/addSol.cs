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
            if(textBox1.Text==" "||textBox2.Text==" ")
            {
            string stmt = @"
            insert into Zolnierz
            (Imię, Nazwisko, IDRangi, DataUrodzenia, GrupaKrwi, Płec, Waga, Wzrost, IDBazy)
            values ('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox2.SelectedValue.ToString()+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+comboBox1.Text+"','"+comboBox5.Text[0] +"','"+trackBar1.Value.ToString()+"','"+trackBar2.Value.ToString()+"','"+comboBox3.SelectedValue.ToString()+"')";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }
            MessageBox.Show(comboBox2.Text + " " + textBox1.Text + " " + textBox2.Text + " dodany do bazy danych");
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


        
    }
}
