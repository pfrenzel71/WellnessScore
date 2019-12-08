namespace WellnessScore
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblPatientNameNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboLine1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cboLine2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboLine3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboLine4 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cboLine5 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnCalculateScore = new System.Windows.Forms.Button();
            this.lblException = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This report was created by [Dr\'s Name] for [Patient\'s Name] [Patient Numner]. The" +
    " following list of parameters wrere mesuared to determine your score:";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(799, 38);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(149, 80);
            this.txtScore.TabIndex = 2;
            // 
            // lblPatientNameNumber
            // 
            this.lblPatientNameNumber.AutoSize = true;
            this.lblPatientNameNumber.Location = new System.Drawing.Point(13, 151);
            this.lblPatientNameNumber.Name = "lblPatientNameNumber";
            this.lblPatientNameNumber.Size = new System.Drawing.Size(159, 13);
            this.lblPatientNameNumber.TabIndex = 3;
            this.lblPatientNameNumber.Text = "[Patient Name] [Patient Number]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age: [yrs]y [mo]mo [days] days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender: [Gender]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exam: [Exam Number]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Exam Date: [Exam Date]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblException);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 304);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Target Range";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnCalculateScore);
            this.groupBox2.Controls.Add(this.cboLine5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.cboLine4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.cboLine3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.cboLine2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.cboLine1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(507, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 307);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Rating";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Anterior Head Syndrome [959]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "0 to 0.59 inches";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "inches";
            // 
            // cboLine1
            // 
            this.cboLine1.FormattingEnabled = true;
            this.cboLine1.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60"});
            this.cboLine1.Location = new System.Drawing.Point(282, 37);
            this.cboLine1.Name = "cboLine1";
            this.cboLine1.Size = new System.Drawing.Size(121, 21);
            this.cboLine1.TabIndex = 7;
            this.cboLine1.SelectedIndexChanged += new System.EventHandler(this.cboLine1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = ".01 Pounds";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Bilateral Weight Scales [2851]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Abnormal Region";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Neck Range of Motion [3047]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Abnormal Region";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Lower Back Range of Motion [3048]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(259, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Abnormal Limitations";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 157);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Upper Body Flexibility [3212]";
            // 
            // cboLine2
            // 
            this.cboLine2.FormattingEnabled = true;
            this.cboLine2.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60"});
            this.cboLine2.Location = new System.Drawing.Point(282, 66);
            this.cboLine2.Name = "cboLine2";
            this.cboLine2.Size = new System.Drawing.Size(121, 21);
            this.cboLine2.TabIndex = 10;
            this.cboLine2.SelectedIndexChanged += new System.EventHandler(this.cboLine2_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(97, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Pounds";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 8;
            // 
            // cboLine3
            // 
            this.cboLine3.FormattingEnabled = true;
            this.cboLine3.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60"});
            this.cboLine3.Location = new System.Drawing.Point(282, 92);
            this.cboLine3.Name = "cboLine3";
            this.cboLine3.Size = new System.Drawing.Size(121, 21);
            this.cboLine3.TabIndex = 13;
            this.cboLine3.SelectedIndexChanged += new System.EventHandler(this.cboLine3_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 11;
            // 
            // cboLine4
            // 
            this.cboLine4.FormattingEnabled = true;
            this.cboLine4.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60"});
            this.cboLine4.Location = new System.Drawing.Point(282, 118);
            this.cboLine4.Name = "cboLine4";
            this.cboLine4.Size = new System.Drawing.Size(121, 21);
            this.cboLine4.TabIndex = 16;
            this.cboLine4.SelectedIndexChanged += new System.EventHandler(this.cboLine4_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 14;
            // 
            // cboLine5
            // 
            this.cboLine5.FormattingEnabled = true;
            this.cboLine5.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60"});
            this.cboLine5.Location = new System.Drawing.Point(282, 143);
            this.cboLine5.Name = "cboLine5";
            this.cboLine5.Size = new System.Drawing.Size(121, 21);
            this.cboLine5.TabIndex = 19;
            this.cboLine5.SelectedIndexChanged += new System.EventHandler(this.cboLine5_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 20);
            this.textBox5.TabIndex = 17;
            // 
            // btnCalculateScore
            // 
            this.btnCalculateScore.Location = new System.Drawing.Point(282, 255);
            this.btnCalculateScore.Name = "btnCalculateScore";
            this.btnCalculateScore.Size = new System.Drawing.Size(121, 23);
            this.btnCalculateScore.TabIndex = 20;
            this.btnCalculateScore.Text = "Calculate Score";
            this.btnCalculateScore.UseVisualStyleBackColor = true;
            this.btnCalculateScore.Click += new System.EventHandler(this.btnCalculateScore_Click);
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(7, 275);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(0, 13);
            this.lblException.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatientNameNumber);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Wellness Score";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblPatientNameNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLine2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboLine1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboLine5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cboLine4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cboLine3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCalculateScore;
        private System.Windows.Forms.Label lblException;
    }
}

