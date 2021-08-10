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

    public partial class Form2 : Form
    {

        private string connstring = String.Format("Server={0};Port={1};" +
               "User Id={2};Password={3};Database={4};",
               "localhost", 5432, "postgres",
               "DeiU99DeiU", "MainDB");

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private string sqlPB;
        private NpgsqlCommand cmdPB;
        private string sqlPC;
        private NpgsqlCommand cmdPC;
        private string sqlA;
        private NpgsqlCommand cmdA;
        private string sqlB;
        private NpgsqlCommand cmdB;
        private string sqlC;
        private NpgsqlCommand cmdC;
        private string sql1;
        private NpgsqlCommand cmd1;
        private string sql2;
        private NpgsqlCommand cmd2;
        private string sql3;
        private NpgsqlCommand cmd3;
        private int rowIndex = -1;
        public int nr1;
        public int nr2;
        public int nr3;

        public string candidate;
        public string candidate2;
        public string candidate3;

        /*
        public Boolean c1 = true;
        public Boolean c2 = true;
        public Boolean c3 = true;

            */




        


        public Form2()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        /*
        public Form2(Boolean s1, Boolean s2, Boolean s3)
        {
            
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

            s1 = c1;
            s2 = c2;
            s3 = c3;


        }
        */
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("            Of course, in one sense, the first essential for a man's being a good citizen is his possession of the home virtues of which we think when we call a man by the emphatic adjective of manly. No man can be a good citizen who is not a good husband and a good father, who is not honest in his dealings with other men and women, faithful to his friends and fearless in the presence of his foes, who has not got a sound heart, a sound mind, and a sound body; exactly as no amount of attention to civil duties will save a nation if the domestic life is undermined, or there is lack of the rude military virtues which alone can assure a country's position in the world. In a free republic the ideal citizen must be one willing and able to take arms for the defense of the flag, exactly as the ideal citizen must be the father of many healthy children. A race must be strong and vigorous; it must be a race of good fighters and good breeders, else its wisdom will come to naught and its virtue be ineffective; and no sweetness and delicacy, no love for and appreciation of beauty in art or literature, no capacity for building up material prosperity can possibly atone for the lack of the great virile virtues.", textBox1);

        }
        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("            I have, myself, full confidence that if all do their duty, if nothing is neglected, and if the best arrangements are made, as they are being made, we shall prove ourselves once again able to defend our Island home, to ride out the storm of war, and to outlive the menace of tyranny, if necessary for years, if necessary alone. At any rate, that is what we are going to try to do. That is the resolve of His Majesty's Government-every man of them. That is the will of Parliament and the nation. The British Empire and the French Republic, linked together in their cause and in their need, will defend to the death their native soil, aiding each other like good comrades to the utmost of their strength. Even though large tracts of Europe and many old and famous States have fallen or may fall into the grip of the Gestapo and all the odious apparatus of Nazi rule, we shall not flag or fail. We shall go on to the end, we shall fight in France, we shall fight on the seas and oceans, we shall fight with growing confidence and growing strength in the air, we shall defend our Island, whatever the cost may be, we shall fight on the beaches, we shall fight on the landing grounds, we shall fight in the fields and in the streets, we shall fight in the hills; we shall never surrender, and even if, which I do not for a moment believe, this Island or a large part of it were subjugated and starving, then our Empire beyond the seas, armed and guarded by the British Fleet, would carry on the struggle, until, in God's good time, the New World, with all its power and might, steps forth to the rescue and the liberation of the old.", textBox2);
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("            Can we forge against these enemies a grand and global alliance, North and South, East and West, that can assure a more fruitful life for all mankind? Will you join in that historic effort?In the long history of the world, only a few generations have been granted the role of defending freedom in its hour of maximum danger.I do not shrink from this responsibility-- I welcome it.I do not believe that any of us would exchange places with any other people or any other generation. The energy, the faith, the devotion which we bring to this endeavor will light our country and all who serve it --and the glow from that fire can truly light the world. And so, my fellow Americans: ask not what your country can do for you-- ask what you can do for your country. My fellow citizens of the world: ask not what America will do for you, but what together we can do for the freedom of man.", textBox3);
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            



            if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {

                /*
                c1 = true;
                c2 = false;
                c3 = false; */

    
                sqlA = @"SELECT ca_votenumber FROM candidate WHERE ca_id = 1";
                cmdA = new NpgsqlCommand(sqlA, conn);
                try
                {
                    nr1 = (int)cmdA.ExecuteScalar();
                    Console.WriteLine("primadata: " + nr1);
                   

                    
                sql1 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 1";
                   cmd1 = new NpgsqlCommand(sql1, conn);
                    nr1++;
                    Console.WriteLine("a doua oara: " + nr1);
                    cmd1.Parameters.AddWithValue("@number", nr1);
                    cmd1.ExecuteNonQuery();
                    
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }catch(Exception errrr) { MessageBox.Show("nu vede"); }
            }

            else if (!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                /*
                c1 =false;
                c2 = true;
                c3 = false; */
                sqlB = @"SELECT ca_votenumber FROM candidate WHERE ca_id =2";
                cmdB = new NpgsqlCommand(sqlB, conn);
                try
                {
                    nr2 = (int)cmdB.ExecuteScalar();
                    Console.WriteLine("primadata: " + nr2);
                    sql2 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 2";
                    cmd2 = new NpgsqlCommand(sql2, conn);
                    nr2++;
                    cmd2.Parameters.AddWithValue("@number", nr2);
                    cmd2.ExecuteNonQuery();
                    
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
                catch (Exception exx) { MessageBox.Show("B"); }
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            { 
                /*
                c1 = false;
                c2 = false;
                c3 = true; */
                sqlC = @"SELECT ca_votenumber FROM candidate WHERE ca_id =3";
                cmdC = new NpgsqlCommand(sqlC, conn);
                try
                {
                    nr3 = (int)cmdC.ExecuteScalar();
                    Console.WriteLine("primadata: " + nr3);
                    sql3 = @"UPDATE candidate SET ca_votenumber = @number WHERE ca_id = 3";
                    cmd3 = new NpgsqlCommand(sql3, conn);
                    nr3++;
                    cmd3.Parameters.AddWithValue("@number", nr3);
                    cmd3.ExecuteNonQuery();
                    // sql2 = @"SELECT * FROM Party WHERE pa_partyname = '" + textBox3.Text + "'";
                    // cmd2 = new NpgsqlCommand(sql2, conn);
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }catch(Exception exx) { MessageBox.Show("C"); }
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Please pick a candidate!");
            }




        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch (Exception err) { MessageBox.Show("nu mere ba"); }

            sql = @"SELECT pa_partyname FROM party WHERE pa_id=1 ";
            cmd = new NpgsqlCommand(sql, conn);
            sqlPB = @"SELECT pa_partyname FROM party WHERE pa_id=2";
            cmdPB = new NpgsqlCommand(sqlPB, conn);
            sqlPC = @"SELECT pa_partyname FROM party WHERE pa_id=3";
            cmdPC = new NpgsqlCommand(sqlPC, conn);
            try
            {
                candidate = (string)cmd.ExecuteScalar();
                candidate2 = (string)cmdPB.ExecuteScalar();
                candidate3 = (string)cmdPC.ExecuteScalar();
                Console.WriteLine("C: "+candidate);
                textBox1.Text = candidate;
                textBox2.Text = candidate2;
                textBox3.Text = candidate3;
            }
            catch(Exception exc) { MessageBox.Show("uite ca nu merge"); }
        }
    }
    
}
