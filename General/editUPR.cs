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
    public partial class editUpr : Form
    {
        globalString connString;
        DataGridViewRow row;
        public editUpr(globalString str, DataGridViewRow r)
        {
            var pr = Application.OpenForms.OfType<Form1>().Single();
            pr.downloadBaz();
            pr.downloadRang();
            InitializeComponent();
            connString = str;
            row = r;

            string IDup = row.Cells[3].Value.ToString();
            textBox1.Text = row.Cells[4].Value.ToString();
            textBox2.Text = row.Cells[5].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();

        }

        private void editUpr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyKat' table. You can move, or remove it, as needed.
            this.pojazdyKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyKat);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyTyp' table. You can move, or remove it, as needed.
            this.pojazdyTypTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyTyp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string update = @"
             update UprawnieniaTab 
             set IDKatUprawnienia='" + comboBox1.SelectedIndex + "', DataNabycia='" + textBox1.Text + "', DataWaznosci='" + textBox2.Text + "'";

                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
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
            else
                MessageBox.Show("Uzupełnij wszystkie dane!");
        }
    }
}
