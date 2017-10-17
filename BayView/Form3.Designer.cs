namespace BayView
{
    partial class Form3
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
            this.lbFeedback = new System.Windows.Forms.Label();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRmPick = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNights = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDisabled = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.btnRmCancel = new System.Windows.Forms.Button();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbAdult = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbChild = new System.Windows.Forms.ComboBox();
            this.btnCost = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNights)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFeedback
            // 
            this.lbFeedback.AutoSize = true;
            this.lbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.ForeColor = System.Drawing.Color.Maroon;
            this.lbFeedback.Location = new System.Drawing.Point(29, 9);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(114, 25);
            this.lbFeedback.TabIndex = 34;
            this.lbFeedback.Text = "lbFeedback";
            this.lbFeedback.Visible = false;
            // 
            // tbLN
            // 
            this.tbLN.Enabled = false;
            this.tbLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLN.Location = new System.Drawing.Point(132, 49);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(390, 30);
            this.tbLN.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Customer";
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(16, 72);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(200, 30);
            this.dtIn.TabIndex = 35;
            this.dtIn.ValueChanged += new System.EventHandler(this.dtIn_ValueChanged);
            // 
            // dtOut
            // 
            this.dtOut.Location = new System.Drawing.Point(16, 131);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(200, 30);
            this.dtOut.TabIndex = 37;
            this.dtOut.ValueChanged += new System.EventHandler(this.dtOut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Depart:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.btnRmPick);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudNights);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbDisabled);
            this.panel1.Controls.Add(this.dtOut);
            this.panel1.Controls.Add(this.dtIn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 230);
            this.panel1.TabIndex = 40;
            // 
            // btnRmPick
            // 
            this.btnRmPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmPick.Location = new System.Drawing.Point(155, 176);
            this.btnRmPick.Name = "btnRmPick";
            this.btnRmPick.Size = new System.Drawing.Size(140, 43);
            this.btnRmPick.TabIndex = 43;
            this.btnRmPick.Text = "NEXT ->";
            this.btnRmPick.UseVisualStyleBackColor = true;
            this.btnRmPick.Click += new System.EventHandler(this.btnRmPick_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nights";
            // 
            // nudNights
            // 
            this.nudNights.Location = new System.Drawing.Point(232, 108);
            this.nudNights.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudNights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNights.Name = "nudNights";
            this.nudNights.Size = new System.Drawing.Size(63, 30);
            this.nudNights.TabIndex = 41;
            this.nudNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNights.ValueChanged += new System.EventHandler(this.nudNights_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Arrive:";
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisabled.Location = new System.Drawing.Point(16, 11);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(230, 24);
            this.cbDisabled.TabIndex = 39;
            this.cbDisabled.Text = "Disabled Access Required";
            this.cbDisabled.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.cbBreakfast);
            this.panel2.Controls.Add(this.btnRmCancel);
            this.panel2.Controls.Add(this.lbRooms);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Enabled = false;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(384, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 230);
            this.panel2.TabIndex = 41;
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBreakfast.Location = new System.Drawing.Point(16, 103);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(103, 44);
            this.cbBreakfast.TabIndex = 44;
            this.cbBreakfast.Text = "Include\r\nBreakfast";
            this.cbBreakfast.UseVisualStyleBackColor = true;
            this.cbBreakfast.CheckedChanged += new System.EventHandler(this.cbBreakfast_CheckedChanged);
            // 
            // btnRmCancel
            // 
            this.btnRmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmCancel.Location = new System.Drawing.Point(16, 176);
            this.btnRmCancel.Name = "btnRmCancel";
            this.btnRmCancel.Size = new System.Drawing.Size(140, 43);
            this.btnRmCancel.TabIndex = 44;
            this.btnRmCancel.Text = "<- RETURN";
            this.btnRmCancel.UseVisualStyleBackColor = true;
            this.btnRmCancel.Click += new System.EventHandler(this.btnRmCancel_Click);
            // 
            // lbRooms
            // 
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.ItemHeight = 25;
            this.lbRooms.Location = new System.Drawing.Point(169, 41);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(120, 179);
            this.lbRooms.TabIndex = 45;
            this.lbRooms.SelectedIndexChanged += new System.EventHandler(this.lbRooms_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Available";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Room Type";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 43);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(140, 33);
            this.cbType.TabIndex = 40;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbAdult
            // 
            this.cbAdult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdult.FormattingEnabled = true;
            this.cbAdult.Location = new System.Drawing.Point(384, 87);
            this.cbAdult.Name = "cbAdult";
            this.cbAdult.Size = new System.Drawing.Size(138, 33);
            this.cbAdult.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Adult";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(736, 49);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 71);
            this.btnQuit.TabIndex = 46;
            this.btnQuit.Text = "Close";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnBook
            // 
            this.btnBook.Enabled = false;
            this.btnBook.Location = new System.Drawing.Point(736, 298);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(86, 71);
            this.btnBook.TabIndex = 45;
            this.btnBook.Text = "Confirm\r\nBooking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Child";
            // 
            // cbChild
            // 
            this.cbChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChild.FormattingEnabled = true;
            this.cbChild.Location = new System.Drawing.Point(167, 87);
            this.cbChild.Name = "cbChild";
            this.cbChild.Size = new System.Drawing.Size(138, 33);
            this.cbChild.TabIndex = 47;
            // 
            // btnCost
            // 
            this.btnCost.Enabled = false;
            this.btnCost.Location = new System.Drawing.Point(736, 137);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(86, 71);
            this.btnCost.TabIndex = 49;
            this.btnCost.Text = "Evaluate\r\nCharge";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(739, 242);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(83, 25);
            this.lblCost.TabIndex = 50;
            this.lblCost.Text = "£charge";
            this.lblCost.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(848, 404);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbChild);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAdult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFeedback);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNights)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFeedback;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.CheckBox cbDisabled;
        private System.Windows.Forms.ComboBox cbAdult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNights;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbChild;
        private System.Windows.Forms.Button btnRmPick;
        private System.Windows.Forms.Button btnRmCancel;
        private System.Windows.Forms.CheckBox cbBreakfast;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Timer timer1;
    }
}