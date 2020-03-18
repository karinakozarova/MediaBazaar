namespace WindowsFormsApp1
{
    partial class StockView
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
            this.stocksViewLbx = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editStockBttn = new System.Windows.Forms.Button();
            this.removeStockBttn = new System.Windows.Forms.Button();
            this.stockNameTbx = new System.Windows.Forms.TextBox();
            this.departmentsCmbbxStockView = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stocksViewLbx
            // 
            this.stocksViewLbx.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksViewLbx.FormattingEnabled = true;
            this.stocksViewLbx.ItemHeight = 44;
            this.stocksViewLbx.Location = new System.Drawing.Point(18, 18);
            this.stocksViewLbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stocksViewLbx.Name = "stocksViewLbx";
            this.stocksViewLbx.Size = new System.Drawing.Size(820, 444);
            this.stocksViewLbx.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 46);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Stock ID";
            // 
            // editStockBttn
            // 
            this.editStockBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStockBttn.Location = new System.Drawing.Point(32, 168);
            this.editStockBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editStockBttn.Name = "editStockBttn";
            this.editStockBttn.Size = new System.Drawing.Size(240, 60);
            this.editStockBttn.TabIndex = 5;
            this.editStockBttn.Text = "Edit stock";
            this.editStockBttn.UseVisualStyleBackColor = true;
            this.editStockBttn.Click += new System.EventHandler(this.editStockBttn_Click);
            // 
            // removeStockBttn
            // 
            this.removeStockBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStockBttn.Location = new System.Drawing.Point(32, 100);
            this.removeStockBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeStockBttn.Name = "removeStockBttn";
            this.removeStockBttn.Size = new System.Drawing.Size(240, 58);
            this.removeStockBttn.TabIndex = 4;
            this.removeStockBttn.Text = "Remove stock";
            this.removeStockBttn.UseVisualStyleBackColor = true;
            this.removeStockBttn.Click += new System.EventHandler(this.removeStockBttn_Click);
            // 
            // stockNameTbx
            // 
            this.stockNameTbx.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTbx.Location = new System.Drawing.Point(849, 88);
            this.stockNameTbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stockNameTbx.Name = "stockNameTbx";
            this.stockNameTbx.Size = new System.Drawing.Size(280, 46);
            this.stockNameTbx.TabIndex = 13;
            this.stockNameTbx.Text = "Stock name";
            // 
            // departmentsCmbbxStockView
            // 
            this.departmentsCmbbxStockView.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsCmbbxStockView.FormattingEnabled = true;
            this.departmentsCmbbxStockView.Location = new System.Drawing.Point(849, 18);
            this.departmentsCmbbxStockView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentsCmbbxStockView.Name = "departmentsCmbbxStockView";
            this.departmentsCmbbxStockView.Size = new System.Drawing.Size(280, 52);
            this.departmentsCmbbxStockView.TabIndex = 11;
            this.departmentsCmbbxStockView.Text = "Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.editStockBttn);
            this.groupBox1.Controls.Add(this.removeStockBttn);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(849, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(294, 274);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock remove/edit";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 483);
            this.Controls.Add(this.stocksViewLbx);
            this.Controls.Add(this.stockNameTbx);
            this.Controls.Add(this.departmentsCmbbxStockView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockView";
            this.Text = "StockView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stocksViewLbx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button editStockBttn;
        private System.Windows.Forms.Button removeStockBttn;
        private System.Windows.Forms.TextBox stockNameTbx;
        private System.Windows.Forms.ComboBox departmentsCmbbxStockView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}