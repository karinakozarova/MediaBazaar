namespace MediaBazar
{
    partial class ReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportControl));
            this.lblSubject = new System.Windows.Forms.Label();
            this.rtbReportMessage = new System.Windows.Forms.RichTextBox();
            this.btnReadReport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnReadReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubject.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(10, 14);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(123, 34);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Subject";
            // 
            // rtbReportMessage
            // 
            this.rtbReportMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbReportMessage.Enabled = false;
            this.rtbReportMessage.Location = new System.Drawing.Point(16, 53);
            this.rtbReportMessage.Name = "rtbReportMessage";
            this.rtbReportMessage.Size = new System.Drawing.Size(376, 127);
            this.rtbReportMessage.TabIndex = 20;
            this.rtbReportMessage.Text = "Report message";
            // 
            // btnReadReport
            // 
            this.btnReadReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReadReport.Image")));
            this.btnReadReport.Location = new System.Drawing.Point(357, 14);
            this.btnReadReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadReport.Name = "btnReadReport";
            this.btnReadReport.Size = new System.Drawing.Size(35, 34);
            this.btnReadReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReadReport.TabIndex = 22;
            this.btnReadReport.TabStop = false;
            this.btnReadReport.Click += new System.EventHandler(this.BtnReadReport_Click);
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnReadReport);
            this.Controls.Add(this.rtbReportMessage);
            this.Controls.Add(this.lblSubject);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(402, 200);
            ((System.ComponentModel.ISupportInitialize)(this.btnReadReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.RichTextBox rtbReportMessage;
        private System.Windows.Forms.PictureBox btnReadReport;
    }
}
