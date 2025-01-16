namespace SensorMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTilt = new System.Windows.Forms.TextBox();
            this.TxtMotion = new System.Windows.Forms.TextBox();
            this.TxtPressure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMoisture = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLight1 = new System.Windows.Forms.Button();
            this.btnLight2 = new System.Windows.Forms.Button();
            this.btnLight3 = new System.Windows.Forms.Button();
            this.btnLight4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnMedicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnStartStop.Location = new System.Drawing.Point(288, 25);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(101, 52);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start / Stop";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TILT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOTION DETECTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRESSURE";
            // 
            // TxtTilt
            // 
            this.TxtTilt.BackColor = System.Drawing.Color.LightGray;
            this.TxtTilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTilt.Location = new System.Drawing.Point(24, 101);
            this.TxtTilt.Name = "TxtTilt";
            this.TxtTilt.ReadOnly = true;
            this.TxtTilt.Size = new System.Drawing.Size(127, 26);
            this.TxtTilt.TabIndex = 4;
            // 
            // TxtMotion
            // 
            this.TxtMotion.BackColor = System.Drawing.Color.LightGray;
            this.TxtMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotion.Location = new System.Drawing.Point(24, 181);
            this.TxtMotion.Name = "TxtMotion";
            this.TxtMotion.ReadOnly = true;
            this.TxtMotion.Size = new System.Drawing.Size(127, 26);
            this.TxtMotion.TabIndex = 5;
            // 
            // TxtPressure
            // 
            this.TxtPressure.BackColor = System.Drawing.Color.LightGray;
            this.TxtPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPressure.Location = new System.Drawing.Point(24, 254);
            this.TxtPressure.Name = "TxtPressure";
            this.TxtPressure.ReadOnly = true;
            this.TxtPressure.Size = new System.Drawing.Size(127, 26);
            this.TxtPressure.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MOISTURE";
            // 
            // TxtMoisture
            // 
            this.TxtMoisture.BackColor = System.Drawing.Color.LightGray;
            this.TxtMoisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMoisture.Location = new System.Drawing.Point(24, 328);
            this.TxtMoisture.Name = "TxtMoisture";
            this.TxtMoisture.ReadOnly = true;
            this.TxtMoisture.Size = new System.Drawing.Size(127, 26);
            this.TxtMoisture.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Threshold settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Service start/stop";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(234, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnLight1
            // 
            this.btnLight1.Location = new System.Drawing.Point(157, 101);
            this.btnLight1.Name = "btnLight1";
            this.btnLight1.Size = new System.Drawing.Size(37, 26);
            this.btnLight1.TabIndex = 13;
            this.btnLight1.UseVisualStyleBackColor = true;
            // 
            // btnLight2
            // 
            this.btnLight2.Location = new System.Drawing.Point(157, 181);
            this.btnLight2.Name = "btnLight2";
            this.btnLight2.Size = new System.Drawing.Size(37, 26);
            this.btnLight2.TabIndex = 14;
            this.btnLight2.UseVisualStyleBackColor = true;
            // 
            // btnLight3
            // 
            this.btnLight3.Location = new System.Drawing.Point(158, 254);
            this.btnLight3.Name = "btnLight3";
            this.btnLight3.Size = new System.Drawing.Size(37, 26);
            this.btnLight3.TabIndex = 15;
            this.btnLight3.UseVisualStyleBackColor = true;
            // 
            // btnLight4
            // 
            this.btnLight4.Location = new System.Drawing.Point(157, 324);
            this.btnLight4.Name = "btnLight4";
            this.btnLight4.Size = new System.Drawing.Size(37, 26);
            this.btnLight4.TabIndex = 16;
            this.btnLight4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mind exercise";
            // 
            // btnMind
            // 
            this.btnMind.Location = new System.Drawing.Point(499, 363);
            this.btnMind.Name = "btnMind";
            this.btnMind.Size = new System.Drawing.Size(44, 24);
            this.btnMind.TabIndex = 18;
            this.btnMind.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.BtnMedicine);
            this.groupBox1.Location = new System.Drawing.Point(237, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 106);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine reminder";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Buzz off";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buzz on";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnMedicine
            // 
            this.BtnMedicine.Location = new System.Drawing.Point(67, 73);
            this.BtnMedicine.Name = "BtnMedicine";
            this.BtnMedicine.Size = new System.Drawing.Size(63, 27);
            this.BtnMedicine.TabIndex = 21;
            this.BtnMedicine.Text = "Reminder";
            this.BtnMedicine.UseVisualStyleBackColor = true;
            this.BtnMedicine.Click += new System.EventHandler(this.BtnMedicine_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLight4);
            this.Controls.Add(this.btnLight3);
            this.Controls.Add(this.btnLight2);
            this.Controls.Add(this.btnLight1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtMoisture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPressure);
            this.Controls.Add(this.TxtMotion);
            this.Controls.Add(this.TxtTilt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alz patient monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTilt;
        private System.Windows.Forms.TextBox TxtMotion;
        private System.Windows.Forms.TextBox TxtPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMoisture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLight1;
        private System.Windows.Forms.Button btnLight2;
        private System.Windows.Forms.Button btnLight3;
        private System.Windows.Forms.Button btnLight4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnMedicine;
    }
}

