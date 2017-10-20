using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace BayView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global variable to hold db path/filename 
        string db;
        //global variable to track logged-in staffid
        int stfid;

        private void Form1_Load(object sender, EventArgs e)
        {
            //try to get db details from LKG file
            try
            {
                using (StreamReader sr = new StreamReader("lkg.txt"))
                {
                    db = sr.ReadLine();
                }
            }
            catch (Exception)
            {
                //otherwise, get details from user
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Title = "Select SQLite database file",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    Filter = "Database files (*.db)|*.db",
                    FilterIndex = 1,
                    FileName = ""
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    db = ofd.FileName;
                }
                else
                {
                    //as no db file was established; exit gracefully
                    MessageBox.Show("Unable to continue without a database connection\n\rApplication will now close");
                    Environment.Exit(0);
                }
            }

            //if  named database file does not exist, the SQLiteconnection Class
            //will create a new, empty, one when you connect. This checks the file
            // exists before we connect; dont want to connect to a new empty one
            if (!File.Exists(db))
            {
                //details in LKG not good, so delete, and advise to restart
                MessageBox.Show("The 'Last Known Good' details were invalid\r\nRestart application and try again");
                File.Delete("lkg.txt");
                Environment.Exit(0);
            }

            //final test, try to read room table
            try
            {
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = @"Data Source=" + db;
                    string sql = "SELECT * FROM room";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        dbcon.Open();
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            //if no data, throw an exception
                            if (!dr.HasRows)
                                throw new Exception();
                        }
                        //connection fully validated
                        dbcon.Close();
                        label3.Text = "Connected to: " + db;
                    }
                }
                //save Last Known Good details
                using (StreamWriter sw = new StreamWriter("lkg.txt",false))
                {
                        sw.WriteLine(db);
                }
            }
            catch (Exception ex)
            {
                //catch any remaining connection problems here
                MessageBox.Show("Db connection failed\r\nApplication will close\r\n"+ex.Message);
                Environment.Exit(0);
            };
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //get staff details from db
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = @"Data Source=" + db;
                    string sql = "SELECT passwd, staffID FROM staff WHERE staffname=@name";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        cmd.Parameters.AddWithValue("name", tbusername.Text);
                        dbcon.Open();
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            //if no match to username in Db, throw an exception
                            if (!dr.HasRows)
                                throw new Exception();
                            //if pasword hashcode doesnt match db, throw an exception
                            string hsh = Coder.GetHash(tbpasswd.Text);
                            dr.Read();
                            if (hsh != dr[0].ToString())
                                throw new Exception();
                            //OK, login is valid
                            stfid = Convert.ToInt32(dr[1]);  //track current staff member
                            dbcon.Close();
                            setlogin(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                showlabel("Login unsuccessful - try again",4000);
                tbusername.Focus();
            }
            finally
            {
                tbusername.Clear();
                tbpasswd.Clear();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            setlogin(false);
        }

        private void btnnewpwd_Click(object sender, EventArgs e)
        {
            setpwdchng(true);
        }

        private void btncnl_Click(object sender, EventArgs e)
        {
            setpwdchng(false);
        }

        private void setlogin(Boolean setas)
        {
            btnnewpwd.Enabled = setas;
            btncust.Enabled = setas;
            btnbook.Enabled = setas;
            btnlogout.Enabled = setas;
            btnlogin.Enabled = !setas;
            tbusername.Enabled = !setas;
            tbpasswd.Enabled = !setas;
        }
            private void setpwdchng(Boolean setas)
        {
            lboldpwd.Visible = setas;
            lbnewpwd1.Visible = setas;
            lblnewpwd2.Visible = setas;
            tbreset0.Clear();
            tbreset1.Clear();
            tbreset2.Clear();
            tbreset0.Visible = setas;
            tbreset1.Visible = setas;
            tbreset2.Visible = setas;
            btnpwd.Visible = setas;
            btncnl.Visible = setas;
            btnlogout.Enabled = !setas;
            btnnewpwd.Enabled = !setas;
            btncust.Enabled = !setas;
            btnbook.Enabled = !setas;
        }

        //display a feedback label
        private void showlabel(string detail,int time)
        {
            lbFeedback.Text = detail;
            lbFeedback.Visible = true;
            timer1.Interval = time;
            timer1.Start();
        }
        //turn off feedback label after3 seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFeedback.Visible = false;
            timer1.Stop();
        }

        private void btnpwd_Click(object sender, EventArgs e)
        {
            SQLiteDataReader dr;
            string sql;
            try
            {
                //if new passwords don't match (case sensitive), throw an exception
                if (string.Compare(tbreset1.Text, tbreset2.Text, false) == -1)
                    throw new Exception(" New passwords don't match");

                //retrieve old password hashcode from db
                string dbhsh;
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = @"Data Source=" + db;
                    sql = "SELECT passwd FROM staff WHERE staffID=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        cmd.Parameters.AddWithValue("id", stfid);
                        dbcon.Open();
                        using (dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            dbhsh = dr[0].ToString();
                        }
                        dbcon.Close();
                    }
                    //if entered password's hashcode is incorrect, throw an exception
                    if (Coder.GetHash(tbreset0.Text) != dbhsh)
                        throw new Exception("Old password is incorrect");
                }

                //write new password hashcode to db
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = @"Data Source=" + db;
                    sql = "UPDATE staff SET passwd=@hsh WHERE staffID=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        cmd.Parameters.AddWithValue("hsh", Coder.GetHash(tbreset1.Text));
                        cmd.Parameters.AddWithValue("id", stfid);
                        dbcon.Open();
                          cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                }
                showlabel("Password was reset",4000);
                setpwdchng(false);
            }
            catch (Exception ex)
            {
                showlabel(ex.Message,4000);
                tbreset0.Clear();
                tbreset1.Clear();
                tbreset2.Clear();
                tbreset0.Focus();
            }
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(@"Data Source=" + db);
            frm2.ShowDialog();
        }

        private void tbpasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnlogin_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(@"Data Source=" + db);
            frm4.ShowDialog();
        }
    }
}