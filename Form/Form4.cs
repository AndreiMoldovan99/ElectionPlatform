using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Autentification
{
    public partial class Form4 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
              "User Id={2};Password={3};Database={4};",
              "localhost", 5432, "postgres",
              "DeiU99DeiU", "MainDB");

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private string sql1;
        private NpgsqlCommand cmd1;
        private string sql2;
        private NpgsqlCommand cmd2;
        private int rowIndex = -1;
        private int candidate3;
        private int candidate1;
        private int candidate2;


        public Form4()
        {
            InitializeComponent();


            Console.WriteLine("cand: " + candidate3);


            chart1.Series["Series1"].IsValueShownAsLabel = true;
            
            
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.Legends[0].BackColor = Color.Transparent;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

                 try
            {
                conn.Open();
            }
            catch (Exception err) { MessageBox.Show("nu mere ba"); }

            sql = @"SELECT ca_votenumber FROM candidate WHERE ca_id= 3";
            cmd = new NpgsqlCommand(sql, conn);
            sql1 = @"SELECT ca_votenumber FROM candidate WHERE ca_id= 1";
            cmd1 = new NpgsqlCommand(sql1, conn);
            sql2 = @"SELECT ca_votenumber FROM candidate WHERE ca_id= 2";
            cmd2 = new NpgsqlCommand(sql2, conn);
            try
            {
                candidate3 = (int)cmd.ExecuteScalar();
                candidate2 = (int)cmd2.ExecuteScalar();
                candidate1 = (int)cmd1.ExecuteScalar();
                Console.WriteLine("Candidati:" +candidate3);
                chart1.Series["Series1"].Points.AddXY("Party A", candidate1);
                chart1.Series["Series1"].Points.AddXY("Party B", candidate2);
                chart1.Series["Series1"].Points.AddXY("Party C", candidate3);
            }
            catch (Exception exception) { MessageBox.Show("nope"); }
        }
    }
}
