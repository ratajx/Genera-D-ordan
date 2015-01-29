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
        string id;
        globalString connString;

        public sklad(globalString conn, string ID)
        {
            InitializeComponent();
            pokaz(ID,conn);
            id = ID;
            connString = conn;
        }

        public void pokaz(string ID,globalString connString)
        {
            string query = "SELECT Imię, Nazwisko from Zolnierz where Zolnierz.IDSkładu = '" + ID + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString.Name);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

        
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "";
            buttonColumn1.Name = "delet";
            buttonColumn1.Text = "Usuń";
            buttonColumn1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn1);

            dataGridView1.Columns["delet"].Width = 35;
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string update = @"UPDATE Zolnierz SET IDSkładu=2 WHERE Imię='" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' AND Nazwisko='" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+ "'";

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
    }
}
