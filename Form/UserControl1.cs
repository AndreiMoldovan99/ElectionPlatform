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
using System.Data.SqlClient;

namespace Autentification
{
    public partial class UserControl1 : UserControl
    {

        private string connstring = String.Format("Server={0};Port={1};" +
               "User Id={2};Password={3};Database={4};",
               "localhost", 5432, "postgres",
               "DeiU99DeiU", "MainDB");

        private NpgsqlConnection conn;
        private string sql;
        private string sql1;
        private NpgsqlCommand cmd;
        private NpgsqlCommand cmd1;
        private int rowIndex = -1;
        public UserControl1()
        {
            InitializeComponent();




        }



        private void button4_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please enter your password!");
            }



            if (!String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please enter your email!");
            }
            if (String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please enter your credentials!");
            }
            if (!String.IsNullOrEmpty(textBox9.Text) && !String.IsNullOrEmpty(textBox6.Text))
            {
                /*
                try
                {
                conn.Open();
                } catch (Exception err) { MessageBox.Show(err.ToString()); }
                sql = @"SELECT * FROM Voter WHERE vtr_username = '" +textBox9.Text +"'";
                cmd = new NpgsqlCommand(sql, conn);
                try
                {
                int result = (int)cmd.ExecuteScalar();
                // Console.WriteLine(result);
                sql1 = @"SELECT * FROM Voter WHERE vtr_password = '" + textBox6.Text + "' AND vtr_username = '" + textBox9.Text +"'";
                cmd1 = new NpgsqlCommand(sql1, conn);
                try
                {
                int result1 = (int)cmd1.ExecuteScalar();
                Console.WriteLine(result1);
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();



                }catch(Exception eroare) { MessageBox.Show("Incorrect password"); }



                }
                catch(Exception eror) { MessageBox.Show("User not registered");



                }
                */
                try
                {
                    conn.Open();
                }
                catch (Exception err) { MessageBox.Show(err.ToString()); }
                sql = @"SELECT * FROM Voter WHERE vtr_username = '" + textBox9.Text + "'";
                cmd = new NpgsqlCommand(sql, conn);
                try
                {
                    int result = (int)cmd.ExecuteScalar();
                    // Console.WriteLine(result);
                    sql1 = @"SELECT * FROM Voter WHERE vtr_password = '" + textBox6.Text + "' AND vtr_username = '" + textBox9.Text + "'";
                    cmd1 = new NpgsqlCommand(sql1, conn);
                    try
                    {
                        int result1 = (int)cmd1.ExecuteScalar();
                        Console.WriteLine(result1);
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();





                    }
                    catch (Exception eroare) { MessageBox.Show("Incorrect password"); }



                }
                catch (Exception eror) { MessageBox.Show("User not registered"); }




                NpgsqlDataReader dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                }




            }





        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
