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
        int i = -1;
        bool flag = false;
        public addMan(globalString str)
        {
            InitializeComponent();
            connString = str;
            dataGridView1.Columns.Add("Sk", "Skład");
            dataGridView1.Columns[0].Width = 150;
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

        public void naMan()
        {
            string st = "SELECT IDUdzialu FROM Sklad WHERE Nazwa='" + comboBox3.Text + "'";
            SqlDataReader rdr = null;
            string IDU;
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(st, thisConnection))
                {
                    thisConnection.Open();
                    rdr = cmdCount.ExecuteReader();
                    rdr.Read();
                    IDU = Convert.ToString(rdr["IDUdzialu"]);
                    thisConnection.Close();
                }
            }
            if (IDU != "")
                MessageBox.Show("Skład uczestniczy w niezakonczononych manewrach! Dodanie go do listy spowoduje usunięcie informacji o bieżących manewrach!","Ostrzeżenie!!!");
            
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

            naMan();
 
        }

        public void dodajSk()
        {
           int count = dataGridView1.RowCount;
            if (i > -1)
            {
                while (comboBox3.Text != dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    i++;
                    if (i == count)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else { flag = true; i = 0; }
            if (flag)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = comboBox3.Text;
                row.Cells.Add(cell);
                dataGridView1.Rows.Add(row);
                flag = false;
                i = 0;
            }
            else
                MessageBox.Show("Skład jest już na liście!");
        }

        public void dodajMan()
        {
            string stmt = @"
            insert into ManewryTab
            (IDManewryKat, IDBazy, DataOd, DataDo,IDSkładu)
            values ('" + (comboBox1.SelectedIndex+1) + "','" + (comboBox2.SelectedIndex+1) + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','1')";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                    thisConnection.Close();
                }
            }

            string last;

            string stmt1 = "SELECT TOP 1 IDManewryTab FROM ManewryTab ORDER BY IDManewryTab DESC";
            SqlDataReader rdr = null;
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt1, thisConnection))
                {
                    thisConnection.Open();
                    rdr = cmdCount.ExecuteReader();
                    rdr.Read();
                    last=Convert.ToString(rdr["IDManewryTab"]);
                    thisConnection.Close();
                }
            }          
            string stmt2 = @"
            insert into Udzial
            (IDManewryTab)
            values ('"+last+"')";
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand query = new SqlCommand(stmt2, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }

            string stmt3 = "SELECT TOP 1 IDUdzial FROM Udzial ORDER BY IDUdzial DESC";
            rdr = null;
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt3, thisConnection))
                {
                    thisConnection.Open();
                    rdr = cmdCount.ExecuteReader();
                    rdr.Read();
                    last = Convert.ToString(rdr["IDUdzial"]);
                    thisConnection.Close();
                }
            }      
            int count = dataGridView1.RowCount;
            for (int j = 0; j < count; j++)
            {
               string stmt4 = @"
               UPDATE Sklad
               SET IDUdzialu ='" + last + "'  WHERE Nazwa='" + dataGridView1.Rows[j].Cells[0].Value.ToString() + "'";
                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
                {
                    using (SqlCommand cmd = new SqlCommand(stmt4, thisConnection))
                    {
                        thisConnection.Open();
                        cmd.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }
                string stmt5 = @"
               UPDATE Zolnierz
               SET Wuzyciu ='1' FROM Zolnierz JOIN Sklad ON Zolnierz.IDSkładu=Sklad.IDSkladu WHERE Sklad.Nazwa='" + dataGridView1.Rows[j].Cells[0].Value.ToString() + "'";
                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
                {
                    using (SqlCommand cmd = new SqlCommand(stmt5, thisConnection))
                    {
                        thisConnection.Open();
                        cmd.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodajSk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount>0)
            {
            dodajMan();
            MessageBox.Show("Manewry zostały dodane");
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            }
            else 
                MessageBox.Show("Żadne składy nie zostały dodane do listy");
        }
        //private void button5_Click(object sender, EventArgs e)
        //{

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            string stmt3 = "SELECT IDUdzialu FROM Sklad WHERE IDSkladu='" + (comboBox3.SelectedIndex+1).ToString() + "'";
            SqlDataReader rdr = null;
            string IDU;
            using (SqlConnection thisConnection = new SqlConnection(connString.Name))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt3, thisConnection))
                {
                    thisConnection.Open();
                    rdr = cmdCount.ExecuteReader();
                    rdr.Read();
                    IDU = Convert.ToString(rdr["IDUdzialu"]);
                    thisConnection.Close();
                }
                sklad n = new sklad(connString, (comboBox3.SelectedIndex + 1).ToString(), IDU);
                n.Show();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            addVeh2Team form = new addVeh2Team(connString);
            form.Show();
        }
    }
}
