﻿using System;
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
    public partial class addVeh : Form
    {
        public addVeh()
        {
            InitializeComponent();
        }

        void dodaj()
        {
            int baza = comboBox2.SelectedIndex+1;
            string stmt = @"insert into PojazdySpis(NazwaPojazdu, NumerRejestracyjny, RokProdukcji, IDBazy, Wuzyciu) values ('"+ comboBox1.Text +"','"+textBox1.Text+"','"+ textBox2.Text+"','"+baza+"','false')";
            using (SqlConnection thisConnection = new SqlConnection("Data Source=SQL5012.myASP.NET;Initial Catalog=DB_9BA4F7_dzordan;User ID=DB_9BA4F7_dzordan_admin;Password=dupadupa8"))
            {
                using (SqlCommand query = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    query.ExecuteNonQuery();
                }
            }
            this.Close();
        }

        private void addVeh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.Bazy' table. You can move, or remove it, as needed.
            this.bazyTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.Bazy);
            // TODO: This line of code loads data into the 'dB_9BA4F7_dzordanDataSet.PojazdySpis' table. You can move, or remove it, as needed.
            this.pojazdySpisTableAdapter.Fill(this.dB_9BA4F7_dzordanDataSet.PojazdySpis);

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
