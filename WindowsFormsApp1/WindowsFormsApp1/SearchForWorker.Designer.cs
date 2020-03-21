namespace WindowsFormsApp1
{
    partial class SearchForEmployee
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
            this.bttnSearchworker = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvWokerView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bttnSearchworker
            // 
            this.bttnSearchworker.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSearchworker.Location = new System.Drawing.Point(8, 367);
            this.bttnSearchworker.Name = "bttnSearchworker";
            this.bttnSearchworker.Size = new System.Drawing.Size(311, 37);
            this.bttnSearchworker.TabIndex = 39;
            this.bttnSearchworker.Text = "Search";
            this.bttnSearchworker.UseVisualStyleBackColor = true;
            this.bttnSearchworker.Click += new System.EventHandler(this.bttnSearchworker_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(8, 198);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(113, 30);
            this.checkBox8.TabIndex = 73;
            this.checkBox8.Text = "Morning";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(240, 198);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(128, 30);
            this.checkBox7.TabIndex = 72;
            this.checkBox7.Text = "Afternoon";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(122, 198);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(114, 30);
            this.checkBox6.TabIndex = 71;
            this.checkBox6.Text = "Evening ";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 70;
            this.label4.Text = "WorkShifts:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(8, 134);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(324, 37);
            this.cbDepartment.TabIndex = 69;
            this.cbDepartment.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Available days:";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(216, 329);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(103, 30);
            this.checkBox12.TabIndex = 66;
            this.checkBox12.Text = "Sunday";
            this.checkBox12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(207, 295);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(117, 30);
            this.checkBox11.TabIndex = 65;
            this.checkBox11.Text = "Saturday";
            this.checkBox11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(9, 295);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(142, 30);
            this.checkBox5.TabIndex = 63;
            this.checkBox5.Text = "Wednesday";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(122, 261);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(90, 30);
            this.checkBox4.TabIndex = 64;
            this.checkBox4.Text = "Friday";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(8, 329);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(119, 30);
            this.checkBox3.TabIndex = 62;
            this.checkBox3.Text = "Thursday";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(9, 261);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 30);
            this.checkBox2.TabIndex = 61;
            this.checkBox2.Text = "Tuesday";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(216, 261);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 30);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Monday";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbLname
            // 
            this.tbLname.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLname.Location = new System.Drawing.Point(172, 96);
            this.tbLname.Margin = new System.Windows.Forms.Padding(2);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(160, 33);
            this.tbLname.TabIndex = 59;
            // 
            // tbFname
            // 
            this.tbFname.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.Location = new System.Drawing.Point(9, 96);
            this.tbFname.Margin = new System.Windows.Forms.Padding(2);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(159, 33);
            this.tbFname.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Search:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 76;
            this.label3.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 77;
            this.label5.Text = "Last Name:";
            // 
            // lvWokerView
            // 
            this.lvWokerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvWokerView.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWokerView.HideSelection = false;
            this.lvWokerView.Location = new System.Drawing.Point(373, 12);
            this.lvWokerView.Name = "lvWokerView";
            this.lvWokerView.Size = new System.Drawing.Size(580, 399);
            this.lvWokerView.TabIndex = 78;
            this.lvWokerView.UseCompatibleStateImageBehavior = false;
            this.lvWokerView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DateOfBirth";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PhoneNumber";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 94;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(274, 31);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(58, 33);
            this.rbAll.TabIndex = 81;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.Location = new System.Drawing.Point(143, 31);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(124, 33);
            this.rbManager.TabIndex = 80;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployee.Location = new System.Drawing.Point(8, 31);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(137, 33);
            this.rbEmployee.TabIndex = 79;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // SearchForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 423);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.lvWokerView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSearchworker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchForEmployee";
            this.Text = "Search For Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSearchworker;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvWokerView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbEmployee;
    }
}