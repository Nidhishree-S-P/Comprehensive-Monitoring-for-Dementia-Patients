namespace SensorMonitoring
{
    partial class LogViewer
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
            this.lstSesnsorDataViewer = new System.Windows.Forms.ListView();
            this.lstQS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSesnsorDataViewer
            // 
            this.lstSesnsorDataViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstSesnsorDataViewer.Location = new System.Drawing.Point(12, 53);
            this.lstSesnsorDataViewer.Name = "lstSesnsorDataViewer";
            this.lstSesnsorDataViewer.Size = new System.Drawing.Size(745, 202);
            this.lstSesnsorDataViewer.TabIndex = 0;
            this.lstSesnsorDataViewer.UseCompatibleStateImageBehavior = false;
            this.lstSesnsorDataViewer.View = System.Windows.Forms.View.Details;
            // 
            // lstQS
            // 
            this.lstQS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lstQS.Location = new System.Drawing.Point(17, 278);
            this.lstQS.Name = "lstQS";
            this.lstQS.Size = new System.Drawing.Size(385, 167);
            this.lstQS.TabIndex = 1;
            this.lstQS.UseCompatibleStateImageBehavior = false;
            this.lstQS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datetime";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fall Detection";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Motion sensor";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sleeping pattern";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nature call ( Moisture)";
            this.columnHeader5.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Datetime";
            this.columnHeader6.Width = 193;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "User response";
            this.columnHeader7.Width = 155;
            // 
            // btnLogger
            // 
            this.btnLogger.Location = new System.Drawing.Point(12, 13);
            this.btnLogger.Name = "btnLogger";
            this.btnLogger.Size = new System.Drawing.Size(114, 34);
            this.btnLogger.TabIndex = 2;
            this.btnLogger.Text = "Load ";
            this.btnLogger.UseVisualStyleBackColor = true;
            this.btnLogger.Click += new System.EventHandler(this.btnLogger_Click);
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 473);
            this.Controls.Add(this.btnLogger);
            this.Controls.Add(this.lstQS);
            this.Controls.Add(this.lstSesnsorDataViewer);
            this.Name = "LogViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSesnsorDataViewer;
        private System.Windows.Forms.ListView lstQS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnLogger;
    }
}