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
    public partial class editVeh : Form
    {
        globalString connString;
        DataGridViewRow row;

        public editVeh(globalString str, DataGridViewRow r)
        {
            var pr = Application.OpenForms.OfType<Form1>().Single();
            pr.downloadBaz();
            row=r;
            connString=str;
            InitializeComponent();
            textBox1.Text = r.Cells[2].Value.ToString();
            textBox2.Text = r.Cells[3].Value.ToString();
        }

        public void uaktualnij()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string update = @"
             update PojazdySpis
             set NazwaPojazdu='" + comboBox1.Text + "', NumerRejestracyjny='" + textBox1.Text + "', RokProdukcji='" + textBox2.Text+"', IDBazy='" + comboBox2.SelectedValue.ToString() + "' where IDPojazdu = '" + row.Cells[0].Value.ToString() + "'";

                using (SqlConnection thisConnection = new SqlConnection(connString.Name))
                {
                    using (SqlCommand query = new SqlCommand(update, thisConnection))
                    {
                        thisConnection.Open();
                        query.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Zaktualizowano");

                var pr = Application.OpenForms.OfType<Form1>().Single();
                                    
                if (pr.Label59 == "Wszystkie bazy")
                    pr.Veh(true);
                else
                    pr.Veh(false);

                this.Close();
            }
            else
                MessageBox.Show("Uzupełnij wszystkie dane!");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uaktualnij();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editVeh_Load(object sender, EventArgs e)
        {
            var pr = Application.OpenForms.OfType<Form1>().Single();
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Bazy);
            this.pojazdyTypTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyTyp);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(pr.tabBaz[Convert.ToInt32(row.Cells[4].Value.ToString()) - 1]);
            comboBox1.SelectedIndex = comboBox1.FindStringExact(row.Cells[1].Value.ToString());
        }
                
    }
}
