namespace MediaBazar
{
    partial class ChangeSchedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbMorningShift = new System.Windows.Forms.CheckBox();
            this.cbAfternoonShift = new System.Windows.Forms.CheckBox();
            this.cbEveningShift = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEveningShift);
            this.groupBox1.Controls.Add(this.cbAfternoonShift);
            this.groupBox1.Controls.Add(this.cbMorningShift);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(470, 81);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workshifts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSunday);
            this.groupBox2.Controls.Add(this.cbSaturday);
            this.groupBox2.Controls.Add(this.cbFriday);
            this.groupBox2.Controls.Add(this.cbThursday);
            this.groupBox2.Controls.Add(this.cbWednesday);
            this.groupBox2.Controls.Add(this.cbTuesday);
            this.groupBox2.Controls.Add(this.cbMonday);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(470, 129);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available days";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(13, 13);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(431, 40);
            this.cbEmployee.TabIndex = 85;
            this.cbEmployee.Text = "Employee";
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.CbEmployee_SelectedIndexChanged);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(503, 13);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(341, 284);
            this.rtbMessage.TabIndex = 86;
            this.rtbMessage.Text = "Message";
            this.rtbMessage.Enter += new System.EventHandler(this.RtbMessage_Enter);
            this.rtbMessage.Leave += new System.EventHandler(this.RtbMessage_Leave);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(16, 304);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(828, 40);
            this.btnSaveChanges.TabIndex = 87;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // cbMorningShift
            // 
            this.cbMorningShift.AutoSize = true;
            this.cbMorningShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMorningShift.Location = new System.Drawing.Point(10, 33);
            this.cbMorningShift.Name = "cbMorningShift";
            this.cbMorningShift.Size = new System.Drawing.Size(117, 28);
            this.cbMorningShift.TabIndex = 3;
            this.cbMorningShift.Text = "Morning";
            this.cbMorningShift.UseVisualStyleBackColor = true;
            // 
            // cbAfternoonShift
            // 
            this.cbAfternoonShift.AutoSize = true;
            this.cbAfternoonShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfternoonShift.Location = new System.Drawing.Point(155, 33);
            this.cbAfternoonShift.Name = "cbAfternoonShift";
            this.cbAfternoonShift.Size = new System.Drawing.Size(136, 28);
            this.cbAfternoonShift.TabIndex = 4;
            this.cbAfternoonShift.Text = "Afternoon";
            this.cbAfternoonShift.UseVisualStyleBackColor = true;
            // 
            // cbEveningShift
            // 
            this.cbEveningShift.AutoSize = true;
            this.cbEveningShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEveningShift.Location = new System.Drawing.Point(302, 33);
            this.cbEveningShift.Name = "cbEveningShift";
            this.cbEveningShift.Size = new System.Drawing.Size(114, 28);
            this.cbEveningShift.TabIndex = 5;
            this.cbEveningShift.Text = "Evening";
            this.cbEveningShift.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonday.Location = new System.Drawing.Point(10, 30);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(114, 28);
            this.cbMonday.TabIndex = 4;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesday.Location = new System.Drawing.Point(155, 30);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(115, 28);
            this.cbTuesday.TabIndex = 5;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesday.Location = new System.Drawing.Point(302, 30);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(149, 28);
            this.cbWednesday.TabIndex = 6;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursday.Location = new System.Drawing.Point(10, 64);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(125, 28);
            this.cbThursday.TabIndex = 7;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFriday.Location = new System.Drawing.Point(155, 64);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(95, 28);
            this.cbFriday.TabIndex = 8;
            this.cbFriday.Text = "Friday";
            this.cbFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturday.Location = new System.Drawing.Point(302, 64);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(124, 28);
            this.cbSaturday.TabIndex = 9;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSunday.Location = new System.Drawing.Point(10, 98);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(108, 28);
            this.cbSunday.TabIndex = 10;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // ChangeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 356);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeSchedule";
            this.Text = "ChangeSchedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.CheckBox cbEveningShift;
        private System.Windows.Forms.CheckBox cbAfternoonShift;
        private System.Windows.Forms.CheckBox cbMorningShift;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbMonday;
    }
}