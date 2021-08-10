using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentification
{
    public partial class UserControl2 : UserControl
    {
        private string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "DeiU99DeiU", "MainDB");

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private int rowIndex = -1;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = 0;

            if (String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please enter your First Name!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please enter your last Name!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please enter a valid email!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please pick a password!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please confirm your password!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please enter your SSN!");
            }

            if(txt_password.Text != txt_confirmpassword.Text)
            {
                MessageBox.Show("Passwords must match!");
            }
            if (String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please enter valid credentials!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please complete all the fields!");
            }
            if (String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please complete all the fields!");
            }
            if (String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please complete all the fields!");
            }
            if (String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please complete all the fields!");
            }
            if (String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please complete all the fields!");
            }
            if (String.IsNullOrEmpty(txt_firstname.Text) && String.IsNullOrEmpty(txt_lastname.Text) && String.IsNullOrEmpty(txt_email.Text) && String.IsNullOrEmpty(txt_cnp.Text) && String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                MessageBox.Show("Please complete all the fields!");
            }
            if (!String.IsNullOrEmpty(txt_firstname.Text) && !String.IsNullOrEmpty(txt_lastname.Text) && !String.IsNullOrEmpty(txt_email.Text) && !String.IsNullOrEmpty(txt_cnp.Text) && !String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_confirmpassword.Text) && txt_password.Text == txt_confirmpassword.Text)
            {
                if (txt_password.Text != txt_confirmpassword.Text)
                    MessageBox.Show("Password is not the same. Please re-enter your password.");

                if (rowIndex < 0)
                {
                    try
                    {
                        conn.Open();

                        sql = @"SELECT * FROM vtr_insert(:_firstname, :_lastname, :_username, :_password, :_cnp)"; //call catre baza de date pentru insert
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_firstname", txt_firstname.Text);
                        cmd.Parameters.AddWithValue("_lastname", txt_lastname.Text);
                        cmd.Parameters.AddWithValue("_username", txt_email.Text);
                        cmd.Parameters.AddWithValue("_password", txt_password.Text);
                        cmd.Parameters.AddWithValue("_cnp", txt_cnp.Text);
                        result = (int)cmd.ExecuteScalar();

                        conn.Close();

                        if (result == 1)
                        {
                            MessageBox.Show("Registered successfully!");
                            //Select();
                        }
                        else
                        {
                            MessageBox.Show("Register failed! Please try again.");
                        }


                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Register failed! Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Register failed! Please try again.");

                }

            
            this.Hide();
                UserControl1 u1 = new UserControl1();
                u1.Show();
            }

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        
    }
}
