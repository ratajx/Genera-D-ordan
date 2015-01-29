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
    
    public partial class sklad : Form
    {
        string id, idu;
        globalString connString;

        public sklad(globalString conn, string ID,string IDu)
        {
            InitializeComponent();
            id = ID;
            idu = IDu;
            connString = conn;
            add();
            pokaz(ID,conn);
                        
        }

        public void add()
        {
            if (idu != "")
            {
                string stmt1 = "SELECT Nazwa FROM Sklad WHERE Sklad.IDUdzialu='" + idu + "'";
                SqlDataReader rdr = null;
                int i = 0;

                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
                {
                    using (SqlCommand cmdCount = new SqlCommand(stmt1, thisConnection))
                    {
                        thisConnection.Open();
                        rdr = cmdCount.ExecuteReader();

                        while (rdr.Read())
                        {
                            comboBox1.Items.Add(new Item((string)rdr["Nazwa"], i));
                            i++;
                        }
                        thisConnection.Close();
                    }
                }
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
            else
            {
                string stmt1 = "SELECT Nazwa FROM Sklad WHERE Sklad.IDSkladu='" + id + "'";
                SqlDataReader rdr = null;
                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
                {
                    using (SqlCommand cmdCount = new SqlCommand(stmt1, thisConnection))
                    {
                        thisConnection.Open();
                        rdr = cmdCount.ExecuteReader();

                        while (rdr.Read())
                        {
                            comboBox1.Items.Add(new Item((string)rdr["Nazwa"], 0));
                        }
                        thisConnection.Close();
                    }
                }
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }
 


        public void pokaz(string ID,globalString connString)
        {
            string query = "SELECT IDZolnierza,Imię, Nazwisko from Zolnierz JOIN Sklad ON Zolnierz.IDSkładu=Sklad.IDSkladu where Sklad.Nazwa = '" + comboBox1.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Visible = false;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "";
            buttonColumn1.Name = "delet";
            buttonColumn1.Text = "Usuń";
            buttonColumn1.UseColumnTextForButtonValue = true;
            buttonColumn1.Width = 35;
            dataGridView1.Columns.Add(buttonColumn1);

            //dataGridView1.Columns[0].Width = 35;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string update = @"UPDATE Zolnierz SET IDSkładu=NULL,Wuzyciu='0' WHERE IDZolnierza='" +dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+ "'";

                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
                {
                    using (SqlCommand query = new SqlCommand(update, thisConnection))
                    {
                        thisConnection.Open();
                        query.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }
                MessageBox.Show("Zaktualizowano");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSolToSk add = new addSolToSk(connString,id);
            add.Show();
        }

        private void sklad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.Sklad' table. You can move, or remove it, as needed.
            this.skladTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Sklad);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokaz(id, connString);
        }
    }
    public class Item
    {
        public string Name;
        public int Value;
        public Item(string name, int value)
        {
            Name = name; Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }

}
