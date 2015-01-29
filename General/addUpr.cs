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
    public partial class addUpr : Form
    {
        string IDzol;
        string conn;
        
        public addUpr(globalString str, string ID)
        {
            IDzol = ID;
            InitializeComponent();
            conn = str.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUpr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyKat' table. You can move, or remove it, as needed.
            this.pojazdyKatTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyKat);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet1.PojazdyTyp' table. You can move, or remove it, as needed.
            this.pojazdyTypTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet1.PojazdyTyp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int IDkat = comboBox1.SelectedIndex + 1;
            string stmt = @"insert into UprawnieniaTab(IDKatUprawnienia, IDZolnierza, DataNabycia, DataWaznosci) 
        values ('" + IDkat + "','" + IDzol + "','" + textBox1.Text + "','" + textBox1.Text + "')";
            using (SqlConnection thisConnection = new SqlConnection(conn))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
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
