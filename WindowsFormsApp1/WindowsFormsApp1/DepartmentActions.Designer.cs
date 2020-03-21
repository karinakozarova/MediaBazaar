namespace WindowsFormsApp1
{
    partial class DepartmentActions
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.departmentsCmbbxAddingStock = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flpDays = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.neededWorkersCount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.neededWorkersCount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.flpDays);
            this.tabPage1.Controls.Add(this.departmentsCmbbxAddingStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Per Work Shift";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // departmentsCmbbxAddingStock
            // 
            this.departmentsCmbbxAddingStock.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsCmbbxAddingStock.FormattingEnabled = true;
            this.departmentsCmbbxAddingStock.Location = new System.Drawing.Point(26, 24);
            this.departmentsCmbbxAddingStock.Name = "departmentsCmbbxAddingStock";
            this.departmentsCmbbxAddingStock.Size = new System.Drawing.Size(523, 52);
            this.departmentsCmbbxAddingStock.TabIndex = 6;
            this.departmentsCmbbxAddingStock.Text = "Department";
            this.departmentsCmbbxAddingStock.SelectedIndexChanged += new System.EventHandler(this.departmentsCmbbxAddingStock_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Available shifts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1080, 522);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Available employees costs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flpDays
            // 
            this.flpDays.AutoScroll = true;
            this.flpDays.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpDays.Location = new System.Drawing.Point(26, 96);
            this.flpDays.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.flpDays.Name = "flpDays";
            this.flpDays.Size = new System.Drawing.Size(1050, 396);
            this.flpDays.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Needed workers:";
            // 
            // neededWorkersCount
            // 
            this.neededWorkersCount.AutoSize = true;
            this.neededWorkersCount.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neededWorkersCount.Location = new System.Drawing.Point(907, 27);
            this.neededWorkersCount.Name = "neededWorkersCount";
            this.neededWorkersCount.Size = new System.Drawing.Size(32, 44);
            this.neededWorkersCount.TabIndex = 16;
            this.neededWorkersCount.Text = "-";
            // 
            // DepartmentActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "DepartmentActions";
            this.Text = "DepartmentActions";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox departmentsCmbbxAddingStock;
        private System.Windows.Forms.FlowLayoutPanel flpDays;
        private System.Windows.Forms.Label neededWorkersCount;
        private System.Windows.Forms.Label label1;
    }
}