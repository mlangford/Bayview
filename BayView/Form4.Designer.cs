namespace BayView
{
    partial class Form4
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
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.btnInc = new System.Windows.Forms.Button();
            this.lbFeedback1 = new System.Windows.Forms.Label();
            this.btnOcc = new System.Windows.Forms.Button();
            this.btnCust = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOut
            // 
            this.dtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOut.Location = new System.Drawing.Point(286, 59);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(200, 30);
            this.dtOut.TabIndex = 39;
            this.dtOut.ValueChanged += new System.EventHandler(this.dtOut_ValueChanged);
            // 
            // dtIn
            // 
            this.dtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIn.Location = new System.Drawing.Point(57, 59);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(200, 30);
            this.dtIn.TabIndex = 38;
            this.dtIn.ValueChanged += new System.EventHandler(this.dtIn_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "End Datet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Room Type";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(530, 65);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(140, 24);
            this.cbType.TabIndex = 43;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // dgvCust
            // 
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Location = new System.Drawing.Point(54, 201);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.RowTemplate.Height = 24;
            this.dgvCust.Size = new System.Drawing.Size(613, 220);
            this.dgvCust.TabIndex = 45;
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(692, 64);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(107, 24);
            this.btnInc.TabIndex = 50;
            this.btnInc.Text = "Income";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // lbFeedback1
            // 
            this.lbFeedback1.AutoSize = true;
            this.lbFeedback1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback1.ForeColor = System.Drawing.Color.Maroon;
            this.lbFeedback1.Location = new System.Drawing.Point(53, 112);
            this.lbFeedback1.Name = "lbFeedback1";
            this.lbFeedback1.Size = new System.Drawing.Size(114, 25);
            this.lbFeedback1.TabIndex = 51;
            this.lbFeedback1.Text = "lbFeedback";
            this.lbFeedback1.Visible = false;
            // 
            // btnOcc
            // 
            this.btnOcc.Location = new System.Drawing.Point(692, 138);
            this.btnOcc.Name = "btnOcc";
            this.btnOcc.Size = new System.Drawing.Size(107, 24);
            this.btnOcc.TabIndex = 52;
            this.btnOcc.Text = "Occupancy";
            this.btnOcc.UseVisualStyleBackColor = true;
            this.btnOcc.Click += new System.EventHandler(this.btnOcc_Click);
            // 
            // btnCust
            // 
            this.btnCust.Location = new System.Drawing.Point(695, 241);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(104, 70);
            this.btnCust.TabIndex = 54;
            this.btnCust.Text = "Update";
            this.btnCust.UseVisualStyleBackColor = true;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(692, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 21);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "use dates";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(50, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Customer Profiles";
            this.label3.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(692, 393);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 28);
            this.btnQuit.TabIndex = 57;
            this.btnQuit.Text = "Close";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(823, 447);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCust);
            this.Controls.Add(this.btnOcc);
            this.Controls.Add(this.lbFeedback1);
            this.Controls.Add(this.btnInc);
            this.Controls.Add(this.dgvCust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.dtIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Label lbFeedback1;
        private System.Windows.Forms.Button btnOcc;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuit;
    }
}