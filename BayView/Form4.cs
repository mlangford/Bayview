using System;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace BayView
{
    public partial class Form4 : Form
    {
        public Form4(string inString)
        {
            InitializeComponent();
            conString = inString;
        }

        string conString;

        SQLiteDataAdapter daCustInfo;
        DataTable dtCustInfo = new DataTable();

        //ensure time span is always at least one day
        private void dtIn_ValueChanged(object sender, EventArgs e)
        {
            dtOut.MinDate = dtIn.Value.AddDays(1);
            lbFeedback1.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //fill room type list
            cbType.Items.Add("~ all ~");
            cbType.Items.Add("Single");
            cbType.Items.Add("Double");
            cbType.Items.Add("Family");
            cbType.SelectedIndex = 0;
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            try
            {
                //calculate income over period
                using (SQLiteConnection dbcon = new SQLiteConnection(conString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Select Sum(charge) From booking Inner Join room");
                    sb.Append(" On booking.roomid = room.number");
                    sb.Append(" Where @d2 >= booking.startdate");
                    sb.Append(" And booking.enddate >= @d1");
                    if (cbType.SelectedIndex == 0)
                    {
                        sb.Append(";");
                    }
                    else
                    {
                        sb.Append(" And room.type = @rmtyp;");
                    }

                    Single income;

                    using (SQLiteCommand cmd = new SQLiteCommand(sb.ToString(), dbcon))
                    {
                        cmd.Parameters.AddWithValue("@d2", dtOut.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@d1", dtIn.Value.ToString("yyyy-MM-dd"));
                        if (cbType.SelectedIndex!=0)
                            cmd.Parameters.AddWithValue("@rmtyp", cbType.Text);
                        dbcon.Open();
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            income = Convert.ToSingle(dr[0]);
                        }
                        dbcon.Close();
                        lbFeedback1.Text = "Total income: " + income.ToString("C");
                        lbFeedback1.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtOut_ValueChanged(object sender, EventArgs e)
        {
            lbFeedback1.Visible = false;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFeedback1.Visible = false;
        }

        private void btnOcc_Click(object sender, EventArgs e)
        {
            try
            {
                //calculate occupancy over the period
                using (SQLiteConnection dbcon = new SQLiteConnection(conString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Select Count(*) From booking Inner Join room");
                    sb.Append(" On booking.roomid = room.number");
                    sb.Append(" Where @d2 >= booking.startdate");
                    sb.Append(" And booking.enddate >= @d1");
                    if (cbType.SelectedIndex == 0)
                    {
                        sb.Append(";");
                    }
                    else
                    {
                        sb.Append(" And room.type = @rmtyp;");
                    }

                    Single occ;

                    using (SQLiteCommand cmd = new SQLiteCommand(sb.ToString(), dbcon))
                    {
                        cmd.Parameters.AddWithValue("@d2", dtOut.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@d1", dtIn.Value.ToString("yyyy-MM-dd"));
                        if (cbType.SelectedIndex != 0)
                            cmd.Parameters.AddWithValue("@rmtyp", cbType.Text);
                        dbcon.Open();
                          occ = Convert.ToSingle(cmd.ExecuteScalar());
                        dbcon.Close();
                        switch (cbType.SelectedIndex)
                        {
                            case 0:
                                lbFeedback1.Text = "Total room occupancy is " + (occ/27.0).ToString("P");
                                break;
                            case 1:
                                lbFeedback1.Text = "Single room occupancy is " + (occ / 15.0).ToString("P");
                                break;
                            case 2:
                                lbFeedback1.Text = "Double room occupancy is " + (occ / 8.0).ToString("P");
                                break;
                            case 3:
                                lbFeedback1.Text = "Family room occupancy is " + (occ / 4.0).ToString("P");
                                break;
                        }
                        lbFeedback1.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    dbcon.ConnectionString = conString;
                    string sql = @"Select * From (Select (title||' '||firstname||' '||lastname) as name ," +
                                        " sum(charge) as spend From booking Inner Join customer" +
                                        " On booking.customerid = customer.customerid" +
                                        " where name NOT null" +
                                        " Group by name Order by lastname)" +
                                        " order by spend Desc;";
                    daCustInfo = new SQLiteDataAdapter(sql, dbcon);
                    dtCustInfo.Clear();
                    daCustInfo.Fill(dtCustInfo);
                    //bind result to DVG control
                    dgvCust.DataSource= dtCustInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
