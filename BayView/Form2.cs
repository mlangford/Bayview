﻿using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace BayView
{
    public partial class Form2 : Form
    {
        public Form2(string inString)
        {
            InitializeComponent();
            conString = inString;
        }

        string conString;

        SQLiteDataAdapter daSearch;
        DataTable dtSearch = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            //populate the titles drop down
            cbTitle.Items.Add("Mr");
            cbTitle.Items.Add("Ms");
            cbTitle.Items.Add("Mx");
            cbTitle.Items.Add("Dr");
            cbTitle.Items.Add("Professor");
            cbTitle.Items.Add("Reverend");
            cbTitle.Items.Add("Sir");
            cbTitle.Items.Add("Dame");
            cbTitle.Items.Add("Lord");
            cbTitle.Items.Add("Lady");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //set UI controls for Add New customer
            btnFind.Enabled = false;       //cannot use Find
            cbFind.Enabled = false;
            cbFind.Text = "";
            btnBook.Enabled = false;     //cannot use Book
            btnEdit.Enabled = false;      //cannot use Edit
            btnDel.Enabled = false;      //cannot use Edit
            btnAdd.Enabled = false;      //cannot use Add

            dtSearch.Clear();                 //clear any previous search result
            clrinputs();                           //clear any current field contents
            setinputs(true);                   //activate the customer fields
        }

        private void clrinputs()
        {
            cbTitle.Text = "";
            tbFN.Clear();
            tbLN.Clear();
            tbA1.Clear();
            tbA2.Clear();
            tbA3.Clear();
            tbPC.Clear();
            tbPhone.Clear();
        }
        private void setinputs(Boolean setas)
        {
            //enable or disable the customer data fields
            cbTitle.Enabled = setas;
            tbFN.Enabled = setas;
            tbLN.Enabled = setas;
            tbA1.Enabled = setas;
            tbA2.Enabled = setas;
            tbA3.Enabled = setas;
            tbPC.Enabled = setas;
            tbPhone.Enabled = setas;
            btnCancel.Enabled = setas;
            btnSubmit.Enabled = setas;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //reset the UI
            btnFind.Enabled = true;       //can use Find
            cbFind.Enabled = true;    
            btnBook.Enabled = false;     //cannot use Book
            btnEdit.Enabled = false;      //cannot use Edit
            btnDel.Enabled = false;
            btnAdd.Enabled = true;       //can use Add

            dtSearch.Clear();                //clear any previous search result
            clrinputs();                          //clear any current field contents
            setinputs(false);                 //deactivate customer fields
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try { 
                //write new customer data into db
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = conString;
                    string sql;
                    if (btnEdit.Enabled)
                    {
                        //this is an "edit" submit
                        sql = "Update customer Set title=@t, firstname=@f, lastname=@l,"
                             + " address1=@a1, address2=@a2, address3=@a3, postcode=@pc, phone=@pn"
                             +" Where customerID=@cid";
                    }
                    else
                    {
                        //this is an "add" submit
                        sql = "Insert Into customer(title,firstname,lastname,address1,address2,address3,postcode,phone)"
                             + " Values(@t,@f,@l,@a1,@a2,@a3,@pc,@pn)";
                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        //fill required parameter values
                        cmd.Parameters.AddWithValue("t", cbTitle.Text);
                        cmd.Parameters.AddWithValue("f", tbFN.Text);
                        cmd.Parameters.AddWithValue("l", tbLN.Text);
                        cmd.Parameters.AddWithValue("a1", tbA1.Text);
                        cmd.Parameters.AddWithValue("a2", tbA2.Text);
                        cmd.Parameters.AddWithValue("a3", tbA3.Text);
                        cmd.Parameters.AddWithValue("pc", tbPC.Text);
                        cmd.Parameters.AddWithValue("pn", tbPhone.Text);
                        if(btnEdit.Enabled)
                            cmd.Parameters.AddWithValue("cid",  cbFind.SelectedValue);
                        //perform db operation
                        dbcon.Open();
                        cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                }
                //display relevant action feedback message
                if (btnEdit.Enabled)
                {
                    showlabel("Customer Details Updated", 4000);
                    dtSearch.Clear();     //now clear any previous search result
                }
                else
                {
                    showlabel("New Customer Added", 4000);
                }
                //reset the UI by using the 'Cancel' button
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                //display error details and reset UI
                btnCancel_Click(null, null);
                showlabel(ex.Message, 400);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try  {
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = conString;
                    string sql = @"Select * From Customer Where "
                        + "lastname LIKE @search Order By lastname";
                    daSearch = new SQLiteDataAdapter(sql, dbcon);
                    daSearch.SelectCommand.Parameters.AddWithValue("@search", "%" + cbFind.Text + "%");
                    dtSearch.Clear();
                    daSearch.Fill(dtSearch);
                    //bind the search result to the Find comboBox
                    cbFind.DataSource = dtSearch;
                    cbFind.DisplayMember = "lastname";     //show the names
                    cbFind.ValueMember = "customerID";  //return the ids

                    //any customer details found?
                    if (cbFind.Items.Count>0)
                    {
                        //yes - display the 1st record and enabled Book and Edit
                        cbFind.SelectedIndex = 0;
                        cbFind_SelectedIndexChanged(null, null);
                        btnBook.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDel.Enabled = true;
                    }
                    else
                    {
                        //no - reset UI using the cancel button
                        cbFind.SelectedIndex = -1;
                        btnCancel_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make sure we have a customer record to show
            if (cbFind.SelectedIndex >= 0)
            {
                //populate customer fields with selected record details
                cbTitle.Text= dtSearch.Rows[cbFind.SelectedIndex][1].ToString();
                tbFN.Text =dtSearch.Rows[cbFind.SelectedIndex][2].ToString();
                tbLN.Text = dtSearch.Rows[cbFind.SelectedIndex][3].ToString();
                tbA1.Text = dtSearch.Rows[cbFind.SelectedIndex][4].ToString();
                tbA2.Text = dtSearch.Rows[cbFind.SelectedIndex][5].ToString();
                tbA3.Text = dtSearch.Rows[cbFind.SelectedIndex][6].ToString();
                tbPC.Text = dtSearch.Rows[cbFind.SelectedIndex][7].ToString();
                tbPhone.Text = dtSearch.Rows[cbFind.SelectedIndex][8].ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //set UI controls for Edit current customer
            btnFind.Enabled = false;       //cannot use Find
            cbFind.Enabled = false;
            cbFind.Text = "";
            btnBook.Enabled = false;      //cannot use Book
            btnAdd.Enabled = false;       //cannot use Add

            setinputs(true);                    //activate customer fields
        }

        private void cbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows Find comboBox to react to Return key
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnFind_Click(null, null);
            }
        }

        //display a feedback label
        private void showlabel(string detail, int time)
        {
            lbFeedback.Text = detail;
            lbFeedback.Visible = true;
            timer1.Interval = time;
            timer1.Start();
        }

        //hide the feedback label after time set
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbFeedback.Visible = false;
            timer1.Stop();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(conString, Convert.ToInt32(cbFind.SelectedValue), 
                                                        tbLN.Text + ", "+ tbFN.Text + " " + cbTitle.Text);
            frm3.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BEGIN;\n\r");
            sb.Append("Update booking Set customerid = 1 Where customerid = @cid;\n\r");
            sb.Append("Delete From customer Where customerid = @cid;\r\n");
            sb.Append("COMMIT;");

            try
            {
                //delete a customer from the db
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = conString;
                    using (SQLiteCommand cmd = new SQLiteCommand(sb.ToString(), dbcon))
                    {
                        cmd.Parameters.AddWithValue("cid", cbFind.SelectedValue);
                        dbcon.Open();
                        cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                }
                showlabel("Customer Deleted From Database", 4000);
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                showlabel(ex.Message, 4000);
            }

        }
    }
}
