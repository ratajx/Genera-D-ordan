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
    public partial class editMan : Form
    {
        DataGridViewRow row;
        globalString connString;

        public editMan(globalString str,DataGridViewRow r)
        {
            row = r;
            var pr = Application.OpenForms.OfType<Form1>().Single();
            pr.downloadBaz();   

            InitializeComponent();
            connString = str;
            

            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                   
        }

        void uaktualnij()
        {
             string update = @"
             update ManewryTab
             set IDManewryKat='" + comboBox3.SelectedValue.ToString() + "',IDBazy='" + comboBox2.SelectedValue.ToString() + "', DataOd='" + dateTimePicker1.Value.ToShortDateString() + "', DataDo='" + dateTimePicker2.Value.ToShortDateString() + "', IDSkładu='" + comboBox1.SelectedValue.ToString() + "' where IDManewryTab = '" + row.Cells[0].Value.ToString() + "'";

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
                                    
                if (pr.Label60 == "Wszystkie bazy")
                    pr.Man(true);
                else
                    pr.Man(false);

                this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uaktualnij();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editMan_Load(object sender, EventArgs e)
        {
            
            
            var pr = Application.OpenForms.OfType<Form1>().Single();
            this.skladTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Sklad);
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.Bazy);
            this.manewryKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.ManewryKat);
            comboBox1.SelectedIndex =Convert.ToInt32(row.Cells[5].Value.ToString())-1;
            comboBox2.SelectedIndex = comboBox2.FindStringExact(pr.tabBaz[Convert.ToInt32(row.Cells[2].Value.ToString()) - 1]);
            comboBox3.SelectedIndex = Convert.ToInt32(row.Cells[1].Value.ToString()) - 1;
        }
    }
}
