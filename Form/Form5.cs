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
    public partial class Form5 : Form
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

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox9e.Text) && !String.IsNullOrEmpty(textBox6e.Text))
            {
                MessageBox.Show("Please enter your email!");
            }

            if (!String.IsNullOrEmpty(textBox9e.Text) && String.IsNullOrEmpty(textBox6e.Text))
            {
                MessageBox.Show("Please enter your new password!");
            }
            if (String.IsNullOrEmpty(textBox1e.Text) && String.IsNullOrEmpty(textBox9e.Text) && String.IsNullOrEmpty(textBox9e.Text))
            {
                MessageBox.Show("Please enter your new credentials!");
            }
            if (textBox1e.Text != textBox6e.Text)
            {
                MessageBox.Show("Passwords must match! ");
            }
            if (!String.IsNullOrEmpty(textBox1e.Text) && !String.IsNullOrEmpty(textBox6e.Text) && !String.IsNullOrEmpty(textBox9e.Text) && textBox1e.Text == textBox6e.Text)
            {
                
                try
                {
                    conn.Open();
                }catch (Exception err) { MessageBox.Show(err.ToString()); }
                sql = @"SELECT *  FROM Voter WHERE vtr_username = '" + textBox9e.Text + "'";
                // update
                cmd = new NpgsqlCommand(sql, conn);
                try
                {
                    int result = (int)cmd.ExecuteScalar();
                  //  Console.WriteLine(result);
                    sql1 = @"UPDATE Voter SET vtr_password = @pass WHERE vtr_username = '" + textBox9e.Text + "'";
                    cmd1 = new NpgsqlCommand(sql1, conn);
                    cmd1.Parameters.AddWithValue("@pass", textBox1e.Text);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception eroare) { MessageBox.Show("User not found"); }
                this.Hide();
                Form1 forma11 = new Form1();
                forma11.ShowDialog();
                
                
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
