namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stocksTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.departmentsTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.flpDepartments = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.stocksTab.SuspendLayout();
            this.departmentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeesTab);
            this.tabControl1.Controls.Add(this.stocksTab);
            this.tabControl1.Controls.Add(this.departmentsTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1141, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.button6);
            this.employeesTab.Controls.Add(this.button5);
            this.employeesTab.Controls.Add(this.button4);
            this.employeesTab.Controls.Add(this.button1);
            this.employeesTab.Location = new System.Drawing.Point(4, 25);
            this.employeesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesTab.Size = new System.Drawing.Size(1133, 463);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(31, 312);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1023, 52);
            this.button6.TabIndex = 30;
            this.button6.Text = "Search for employee";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(31, 221);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(1023, 52);
            this.button5.TabIndex = 29;
            this.button5.Text = "Fire employee";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(31, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1023, 52);
            this.button4.TabIndex = 28;
            this.button4.Text = "Remove employee from the system";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1023, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Create account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // stocksTab
            // 
            this.stocksTab.Controls.Add(this.button3);
            this.stocksTab.Controls.Add(this.button2);
            this.stocksTab.Location = new System.Drawing.Point(4, 25);
            this.stocksTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocksTab.Name = "stocksTab";
            this.stocksTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocksTab.Size = new System.Drawing.Size(1133, 463);
            this.stocksTab.TabIndex = 1;
            this.stocksTab.Text = "Stocks";
            this.stocksTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(41, 109);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1023, 52);
            this.button3.TabIndex = 28;
            this.button3.Text = "View upcoming shelf requests";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(41, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1023, 52);
            this.button2.TabIndex = 27;
            this.button2.Text = "Create stock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // departmentsTab
            // 
            this.departmentsTab.Controls.Add(this.flpDepartments);
            this.departmentsTab.Controls.Add(this.label4);
            this.departmentsTab.Location = new System.Drawing.Point(4, 25);
            this.departmentsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentsTab.Name = "departmentsTab";
            this.departmentsTab.Size = new System.Drawing.Size(1133, 463);
            this.departmentsTab.TabIndex = 2;
            this.departmentsTab.Text = "Departments";
            this.departmentsTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Departments:";
            // 
            // flpDepartments
            // 
            this.flpDepartments.AutoScroll = true;
            this.flpDepartments.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpDepartments.Location = new System.Drawing.Point(36, 85);
            this.flpDepartments.Name = "flpDepartments";
            this.flpDepartments.Size = new System.Drawing.Size(1072, 348);
            this.flpDepartments.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 504);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Media Bazar";
            this.tabControl1.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.stocksTab.ResumeLayout(false);
            this.departmentsTab.ResumeLayout(false);
            this.departmentsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesTab;
        private System.Windows.Forms.TabPage stocksTab;
        private System.Windows.Forms.TabPage departmentsTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flpDepartments;
    }
}