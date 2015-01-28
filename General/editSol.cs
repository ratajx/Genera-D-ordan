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
    public partial class editSol : Form
    {
        globalString connString;

        public editSol(globalString str)
        {
            InitializeComponent();
            connString = str;
        }

        void uaktualnij()
        {
            string updateString = @"
            update Zolnierz
            set CategoryName = 'Other'
             where IDZolnierza = '"+   +"'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uaktualnij();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
