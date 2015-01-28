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
    public partial class pojazd_sz : Form
    {
        globalString connString;
        public pojazd_sz(string nazwa,globalString conn)
        {
            InitializeComponent();
            connString = conn;
            dane(nazwa);
            
        }
        
        void dane(string nazwa)
        {
            SqlConnection thisConnection = new SqlConnection(connString.Name);
            string query ="SELECT Nazwa FROM PojazdyKat JOIN PojazdyTyp ON PojazdyKat.IDKatPojazdu=PojazdyTyp.IDKatPojazdu WHERE PojazdyTyp.NazwaPojazdu='"+nazwa+"'";// WHERE PojazdyTyp.NazwaPojazdu='" + nazwa + "'";


            label1.Text = pokaz(query, thisConnection,"Nazwa");
            label1.MaximumSize = new Size(150, 0);
            label1.AutoSize = true;
          
            query ="SELECT Masa FROM PojazdyTyp WHERE NazwaPojazdu='" + nazwa + "'";
            label2.Text = pokaz(query, thisConnection,"Masa") +"kg";
           
            query = "SELECT Ładowność FROM PojazdyTyp WHERE NazwaPojazdu='" + nazwa + "'";
            label3.Text = pokaz(query, thisConnection, "Ładowność") + "kg";
        }

        string pokaz(string query,SqlConnection thisConnection,string column)
        {
            SqlCommand cmdQuery = new SqlCommand(query, thisConnection);
            SqlDataReader reader = null;
            thisConnection.Open();
            reader = cmdQuery.ExecuteReader();
            reader.Read();
            string text = reader[column].ToString();
            reader.Close();
            thisConnection.Close();
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
