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
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "DeiU99DeiU", "MainDB");

        private NpgsqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.SendToBack();
            button3.SendToBack();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.ShowDialog();
        }
    }
}
