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
            this.button3 = new System.Windows.Forms.Button();
            this.lblRequestDescription = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(549, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Decline";
            this.button3.UseVisualStyleBackColor = true;
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
            this.lblRequest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRequest.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(7, 17);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(132, 34);
            this.lblRequest.TabIndex = 17;
            this.lblRequest.Text = "Request";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(460, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblRequestDescription);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(648, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblRequestDescription;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
