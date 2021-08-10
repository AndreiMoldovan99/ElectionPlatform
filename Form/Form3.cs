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
    

    public partial class Form3 : Form
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
        private int nr;

        private Boolean cc1;
        private Boolean cc2;
        private Boolean cc3;
      

        public Form3()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            Form2 f22 = new Form2(cc1,cc2,cc3);
            cc1 = f22.c1;
            cc2 = f22.c2;
            cc3 = f22.c3;
            Console.WriteLine("1:"+cc1 );
            Console.WriteLine("2:" + cc2);
            Console.WriteLine("3:" + cc3);

            */

            sql = @"SELECT ca_votenumber FROM candidate WHERE ca_id = 1";
            cmd = new NpgsqlCommand(sql, conn);
            try
            {
                nr = (int)cmd.ExecuteScalar();
                Console.WriteLine("primadata: " + nr);



                sql1 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 1";
                cmd1 = new NpgsqlCommand(sql1, conn);
                nr--;
                Console.WriteLine("a doua oara: " + nr);
                cmd1.Parameters.AddWithValue("@number", nr);
                cmd1.ExecuteNonQuery();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            catch (Exception errrr) { MessageBox.Show("nu vede"); }

            /*
            if (cc1 == true)
            {
                sql = @"SELECT ca_votenumber FROM candidate WHERE ca_id = 1";
                cmd = new NpgsqlCommand(sql, conn);
                try
                {
                    nr = (int)cmd.ExecuteScalar();
                    Console.WriteLine("primadata: " + nr);



                    sql1 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 1";
                    cmd1 = new NpgsqlCommand(sql1, conn);
                    nr--;
                    Console.WriteLine("a doua oara: " + nr);
                    cmd1.Parameters.AddWithValue("@number", nr);
                    cmd1.ExecuteNonQuery();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                catch (Exception errrr) { MessageBox.Show("nu vede"); }
            }
            if (cc2 == true)
            {
                sql = @"SELECT ca_votenumber FROM candidate WHERE ca_id = 2";
                cmd = new NpgsqlCommand(sql, conn);
                try
                {
                    nr = (int)cmd.ExecuteScalar();
                    Console.WriteLine("primadata: " + nr);



                    sql1 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 2";
                    cmd1 = new NpgsqlCommand(sql1, conn);
                    nr--;
                    Console.WriteLine("a doua oara: " + nr);
                    cmd1.Parameters.AddWithValue("@number", nr);
                    cmd1.ExecuteNonQuery();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                catch (Exception errrr) { MessageBox.Show("nu vede"); }
            }
            if (cc3 == true)
            {
                sql = @"SELECT ca_votenumber FROM candidate WHERE ca_id = 3";
                cmd = new NpgsqlCommand(sql, conn);
                try
                {
                    nr = (int)cmd.ExecuteScalar();
                    Console.WriteLine("primadata: " + nr);



                    sql1 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 3";
                    cmd1 = new NpgsqlCommand(sql1, conn);
                    nr--;
                    Console.WriteLine("a doua oara: " + nr);
                    cmd1.Parameters.AddWithValue("@number", nr);
                    cmd1.ExecuteNonQuery();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                catch (Exception errrr) { MessageBox.Show("nu vede"); }
            }

    */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch (Exception err) { MessageBox.Show("nu mere ba"); }


        }
    }
}
