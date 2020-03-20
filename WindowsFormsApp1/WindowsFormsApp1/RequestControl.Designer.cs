namespace WindowsFormsApp1
{
    partial class RequestControl
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
            this.btnDecline = new System.Windows.Forms.Button();
            this.lblRequestDescription = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.Silver;
            this.btnDecline.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.Location = new System.Drawing.Point(549, 101);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(78, 33);
            this.btnDecline.TabIndex = 19;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.BtnDecline_Click);
            // 
            // lblRequestDescription
            // 
            this.lblRequestDescription.AutoSize = true;
            this.lblRequestDescription.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDescription.Location = new System.Drawing.Point(9, 63);
            this.lblRequestDescription.Name = "lblRequestDescription";
            this.lblRequestDescription.Size = new System.Drawing.Size(336, 20);
            this.lblRequestDescription.TabIndex = 18;
            this.lblRequestDescription.Text = "Some description of the request here";
            this.lblRequestDescription.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRequest.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(7, 17);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(132, 34);
            this.lblRequest.TabIndex = 17;
            this.lblRequest.Text = "Request";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Silver;
            this.btnDetails.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(13, 101);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(73, 33);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Silver;
            this.btnApprove.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(460, 101);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(83, 33);
            this.btnApprove.TabIndex = 15;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.lblRequestDescription);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnApprove);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(646, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Label lblRequestDescription;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnApprove;
    }
}
