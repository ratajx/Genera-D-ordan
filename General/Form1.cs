using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace General
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Zolnierz' table. You can move, or remove it, as needed.
            this.zolnierzTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Zolnierz);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Bazy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updateString = @"
     update Bazy
     set Numer = 666
     where Miasto = 'Poznań'";
            
            // 1. Instantiate a new command with command text only
            SqlCommand cmd = new SqlCommand(updateString);

            SqlConnection con=new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8");
            // 2. Set the Connection property 
            con.Open();
            cmd.Connection = con;
            
            // 3. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string updateString = @"
    SELECT Zolnierz.Imię, Zolnierz.Nazwisko, Rangi.NazwaRangi
    FROM Zolnierz
    JOIN Rangi
    ON Zolnierz.IDRangi=Rangi.IDRangi";

            // 1. Instantiate a new command with command text only
            SqlCommand cmd = new SqlCommand(updateString);

            SqlConnection con = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8");
            // 2. Set the Connection property 
            con.Open();
            cmd.Connection = con;
            SqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                Console.Write(rdr[0]);
                Console.Write(" "+rdr[1]);
                Console.WriteLine(" "+rdr[2]);
            }






        }

     
    }
}
