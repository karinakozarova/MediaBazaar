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
            this.shiftsSelectionCmbbx = new System.Windows.Forms.ComboBox();
            this.departmentsCmbbxAddingStock = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.morningPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.afternoonPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eveningPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.morningPanel.SuspendLayout();
            this.afternoonPanel.SuspendLayout();
            this.eveningPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.eveningPanel);
            this.tabPage1.Controls.Add(this.afternoonPanel);
            this.tabPage1.Controls.Add(this.morningPanel);
            this.tabPage1.Controls.Add(this.shiftsSelectionCmbbx);
            this.tabPage1.Controls.Add(this.departmentsCmbbxAddingStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Per Work Shift";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shiftsSelectionCmbbx
            // 
            this.shiftsSelectionCmbbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsSelectionCmbbx.FormattingEnabled = true;
            this.shiftsSelectionCmbbx.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.shiftsSelectionCmbbx.Location = new System.Drawing.Point(583, 24);
            this.shiftsSelectionCmbbx.Name = "shiftsSelectionCmbbx";
            this.shiftsSelectionCmbbx.Size = new System.Drawing.Size(432, 52);
            this.shiftsSelectionCmbbx.TabIndex = 7;
            this.shiftsSelectionCmbbx.Text = "Shift";
            this.shiftsSelectionCmbbx.SelectedIndexChanged += new System.EventHandler(this.departmentsCmbbxAddingStock_SelectedIndexChanged);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 526);
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
            // morningPanel
            // 
            this.morningPanel.BackColor = System.Drawing.Color.LightGreen;
            this.morningPanel.Controls.Add(this.label11);
            this.morningPanel.Location = new System.Drawing.Point(53, 164);
            this.morningPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.morningPanel.Name = "morningPanel";
            this.morningPanel.Size = new System.Drawing.Size(277, 128);
            this.morningPanel.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(14, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 109;
            this.label11.Text = "Morning";
            // 
            // afternoonPanel
            // 
            this.afternoonPanel.BackColor = System.Drawing.Color.Cyan;
            this.afternoonPanel.Controls.Add(this.label1);
            this.afternoonPanel.Location = new System.Drawing.Point(388, 164);
            this.afternoonPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.afternoonPanel.Name = "afternoonPanel";
            this.afternoonPanel.Size = new System.Drawing.Size(277, 128);
            this.afternoonPanel.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "Afternoon";
            // 
            // eveningPanel
            // 
            this.eveningPanel.BackColor = System.Drawing.Color.LightGreen;
            this.eveningPanel.Controls.Add(this.label2);
            this.eveningPanel.Location = new System.Drawing.Point(721, 164);
            this.eveningPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eveningPanel.Name = "eveningPanel";
            this.eveningPanel.Size = new System.Drawing.Size(277, 128);
            this.eveningPanel.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Evening";
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
            this.morningPanel.ResumeLayout(false);
            this.morningPanel.PerformLayout();
            this.afternoonPanel.ResumeLayout(false);
            this.afternoonPanel.PerformLayout();
            this.eveningPanel.ResumeLayout(false);
            this.eveningPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox departmentsCmbbxAddingStock;
        private System.Windows.Forms.ComboBox shiftsSelectionCmbbx;
        private System.Windows.Forms.Panel eveningPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel afternoonPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel morningPanel;
        private System.Windows.Forms.Label label11;
    }
}