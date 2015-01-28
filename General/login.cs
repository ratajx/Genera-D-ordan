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
    public partial class login : Form
    {
        public globalString s = new globalString();
        public login()
        {
            InitializeComponent();
        }
        void test()
        {
            bool run = true;
            using (SqlConnection thisConnection = new SqlConnection(s.Name))
            {
                try
                {
                    thisConnection.Open();
                }
                catch (Exception ex)
                {
                    run = false;
                    MessageBox.Show("Wprowadzono błędne dane!", "Błąd logowania");
                }
                if (run)
                {
                    thisConnection.Close();
                    Form1 form = new Form1(s, this);
                    form.Show();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Name = "Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";User ID=" + textBox3.Text + ";Password=" + textBox4.Text;
            test();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
