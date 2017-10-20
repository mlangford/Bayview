namespace BayView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnewpwd = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tbreset0 = new System.Windows.Forms.TextBox();
            this.lboldpwd = new System.Windows.Forms.Label();
            this.tbreset1 = new System.Windows.Forms.TextBox();
            this.lbnewpwd1 = new System.Windows.Forms.Label();
            this.tbreset2 = new System.Windows.Forms.TextBox();
            this.lblnewpwd2 = new System.Windows.Forms.Label();
            this.btnpwd = new System.Windows.Forms.Button();
            this.btncnl = new System.Windows.Forms.Button();
            this.lbFeedback = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Username";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(193, 24);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(312, 34);
            this.tbusername.TabIndex = 3;
            // 
            // tbpasswd
            // 
            this.tbpasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpasswd.Location = new System.Drawing.Point(193, 74);
            this.tbpasswd.Name = "tbpasswd";
            this.tbpasswd.PasswordChar = '#';
            this.tbpasswd.Size = new System.Drawing.Size(312, 34);
            this.tbpasswd.TabIndex = 5;
            this.tbpasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpasswd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btnnewpwd
            // 
            this.btnnewpwd.Enabled = false;
            this.btnnewpwd.Location = new System.Drawing.Point(612, 330);
            this.btnnewpwd.Name = "btnnewpwd";
            this.btnnewpwd.Size = new System.Drawing.Size(86, 47);
            this.btnnewpwd.TabIndex = 6;
            this.btnnewpwd.Text = "New\r\nPassword";
            this.btnnewpwd.UseVisualStyleBackColor = true;
            this.btnnewpwd.Click += new System.EventHandler(this.btnnewpwd_Click);
            // 
            // btncust
            // 
            this.btncust.Enabled = false;
            this.btncust.Location = new System.Drawing.Point(612, 201);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(86, 71);
            this.btncust.TabIndex = 7;
            this.btncust.Text = "Customers";
            this.btncust.UseVisualStyleBackColor = true;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // btnbook
            // 
            this.btnbook.Enabled = false;
            this.btnbook.Location = new System.Drawing.Point(612, 123);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(86, 71);
            this.btnbook.TabIndex = 8;
            this.btnbook.Text = "Bookings";
            this.btnbook.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(430, 123);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 28);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Submit";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            // 
            // btnlogout
            // 
            this.btnlogout.Enabled = false;
            this.btnlogout.Location = new System.Drawing.Point(612, 24);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 42);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // tbreset0
            // 
            this.tbreset0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreset0.Location = new System.Drawing.Point(193, 204);
            this.tbreset0.Name = "tbreset0";
            this.tbreset0.PasswordChar = '#';
            this.tbreset0.Size = new System.Drawing.Size(312, 34);
            this.tbreset0.TabIndex = 13;
            this.tbreset0.Visible = false;
            // 
            // lboldpwd
            // 
            this.lboldpwd.AutoSize = true;
            this.lboldpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboldpwd.Location = new System.Drawing.Point(20, 204);
            this.lboldpwd.Name = "lboldpwd";
            this.lboldpwd.Size = new System.Drawing.Size(132, 25);
            this.lboldpwd.TabIndex = 12;
            this.lboldpwd.Text = "Old password";
            this.lboldpwd.Visible = false;
            // 
            // tbreset1
            // 
            this.tbreset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreset1.Location = new System.Drawing.Point(193, 250);
            this.tbreset1.Name = "tbreset1";
            this.tbreset1.PasswordChar = '#';
            this.tbreset1.Size = new System.Drawing.Size(312, 34);
            this.tbreset1.TabIndex = 15;
            this.tbreset1.Visible = false;
            // 
            // lbnewpwd1
            // 
            this.lbnewpwd1.AutoSize = true;
            this.lbnewpwd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewpwd1.Location = new System.Drawing.Point(20, 250);
            this.lbnewpwd1.Name = "lbnewpwd1";
            this.lbnewpwd1.Size = new System.Drawing.Size(140, 25);
            this.lbnewpwd1.TabIndex = 14;
            this.lbnewpwd1.Text = "New password";
            this.lbnewpwd1.Visible = false;
            // 
            // tbreset2
            // 
            this.tbreset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreset2.Location = new System.Drawing.Point(193, 300);
            this.tbreset2.Name = "tbreset2";
            this.tbreset2.PasswordChar = '#';
            this.tbreset2.Size = new System.Drawing.Size(312, 34);
            this.tbreset2.TabIndex = 17;
            this.tbreset2.Visible = false;
            // 
            // lblnewpwd2
            // 
            this.lblnewpwd2.AutoSize = true;
            this.lblnewpwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpwd2.Location = new System.Drawing.Point(20, 300);
            this.lblnewpwd2.Name = "lblnewpwd2";
            this.lblnewpwd2.Size = new System.Drawing.Size(115, 25);
            this.lblnewpwd2.TabIndex = 16;
            this.lblnewpwd2.Text = "Repeat new";
            this.lblnewpwd2.Visible = false;
            // 
            // btnpwd
            // 
            this.btnpwd.Location = new System.Drawing.Point(430, 349);
            this.btnpwd.Name = "btnpwd";
            this.btnpwd.Size = new System.Drawing.Size(75, 28);
            this.btnpwd.TabIndex = 18;
            this.btnpwd.Text = "Submit";
            this.btnpwd.UseVisualStyleBackColor = true;
            this.btnpwd.Visible = false;
            this.btnpwd.Click += new System.EventHandler(this.btnpwd_Click);
            // 
            // btncnl
            // 
            this.btncnl.Location = new System.Drawing.Point(349, 349);
            this.btncnl.Name = "btncnl";
            this.btncnl.Size = new System.Drawing.Size(75, 28);
            this.btncnl.TabIndex = 19;
            this.btncnl.Text = "Cancel";
            this.btncnl.UseVisualStyleBackColor = true;
            this.btncnl.Visible = false;
            this.btncnl.Click += new System.EventHandler(this.btncnl_Click);
            // 
            // lbFeedback
            // 
            this.lbFeedback.AutoSize = true;
            this.lbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.ForeColor = System.Drawing.Color.Maroon;
            this.lbFeedback.Location = new System.Drawing.Point(190, 158);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(114, 25);
            this.lbFeedback.TabIndex = 20;
            this.lbFeedback.Text = "lbFeedback";
            this.lbFeedback.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "#";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbFeedback);
            this.Controls.Add(this.btncnl);
            this.Controls.Add(this.btnpwd);
            this.Controls.Add(this.tbreset2);
            this.Controls.Add(this.lblnewpwd2);
            this.Controls.Add(this.tbreset1);
            this.Controls.Add(this.lbnewpwd1);
            this.Controls.Add(this.tbreset0);
            this.Controls.Add(this.lboldpwd);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.btnnewpwd);
            this.Controls.Add(this.tbpasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bay View Hotel Inormation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnewpwd;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TextBox tbreset0;
        private System.Windows.Forms.Label lboldpwd;
        private System.Windows.Forms.TextBox tbreset1;
        private System.Windows.Forms.Label lbnewpwd1;
        private System.Windows.Forms.TextBox tbreset2;
        private System.Windows.Forms.Label lblnewpwd2;
        private System.Windows.Forms.Button btnpwd;
        private System.Windows.Forms.Button btncnl;
        private System.Windows.Forms.Label lbFeedback;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

