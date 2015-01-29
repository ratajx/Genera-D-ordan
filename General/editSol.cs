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
    public partial class editSol : Form
    {
        globalString connString;
        DataGridViewRow row;

        public editSol(globalString str,DataGridViewRow r)
        {

            var pr = Application.OpenForms.OfType<Form1>().Single();
            pr.downloadBaz();
            pr.downloadRang();
            InitializeComponent();
            connString = str;
            row = r;
            textBox1.Text=row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            trackBar1.Value = Convert.ToInt32(row.Cells[8].Value.ToString());
            trackBar2.Value = Convert.ToInt32(row.Cells[9].Value.ToString());
            comboBox1.Text = row.Cells[6].Value.ToString();
            if(row.Cells[7].Value.ToString()=="M")
                comboBox5.Text = "Mężczyzna";
            else
                comboBox5.Text = "Kobieta";
        }

        void uaktualnij()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string update = @"
             update Zolnierz
             set Imię='"+textBox1.Text+"', Nazwisko='"+textBox2.Text+"', IDRangi='"+comboBox2.SelectedValue.ToString()+"', DataUrodzenia='"+dateTimePicker1.Value.ToShortDateString()+"', GrupaKrwi='"+comboBox1.Text+"', Płec='"+comboBox5.Text[0] +"', Waga='"+trackBar1.Value.ToString()+"', Wzrost='"+trackBar2.Value.ToString()+"', IDBazy='"+comboBox3.SelectedValue.ToString()+"' where IDZolnierza = '" +row.Cells[1].Value.ToString() +"'";

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
                                    
                if (pr.Label9 == "Wszystkie bazy")
                    pr.Bas(true);
                else
                    pr.Bas(false);
                
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

        private void editSol_Load(object sender, EventArgs e)
        {
            var pr = Application.OpenForms.OfType<Form1>().Single();
            this.rangiTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Rangi);
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Bazy);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(pr.tabRang[Convert.ToInt32(row.Cells[4].Value.ToString())-1]);
            comboBox3.SelectedIndex = comboBox3.FindStringExact(pr.tabBaz[Convert.ToInt32(row.Cells[10].Value.ToString())-1]);
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
