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
    public partial class addSol : Form
    {
        public addSol()
        {
            InitializeComponent();
        }

        void dodaj()
        {

            string stmt = @"
            insert into Zolnierz
            (IDZolnierza, Imię, Nazwisko, IDRangi, DataUrodzenia, GrupaKrwi, Płec, Waga, Wzrost, IDBazy, IDSkładu, Wuzyciu)
            values ('Tu Będzie Reszta Kodu xDDDDDD')";
            using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodaj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
