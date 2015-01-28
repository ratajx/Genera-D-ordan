using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General
{
    public partial class login : Form
    {
        public globalString s = new globalString();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Name = "Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";User ID=" + textBox3.Text + ";Password=" + textBox4.Text;

            Form1 form = new Form1(s);
            form.Show();
            
        }
    }
}
