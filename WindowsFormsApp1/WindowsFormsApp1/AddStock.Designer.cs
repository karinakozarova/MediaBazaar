namespace WindowsFormsApp1
{
    partial class AddStock
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
            this.addStockNameTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.indepoQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addStockBttn = new System.Windows.Forms.Button();
            this.departmentsCmbbxAddingStock = new System.Windows.Forms.ComboBox();
            this.inStoreQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pricePerItemTbx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTbx = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.indepoQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerItemTbx)).BeginInit();
            this.SuspendLayout();
            // 
            // addStockNameTbx
            // 
            this.addStockNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockNameTbx.Location = new System.Drawing.Point(40, 63);
            this.addStockNameTbx.Name = "addStockNameTbx";
            this.addStockNameTbx.Size = new System.Drawing.Size(453, 47);
            this.addStockNameTbx.TabIndex = 0;
            this.addStockNameTbx.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "In depo:";
            // 
            // indepoQuantityInput
            // 
            this.indepoQuantityInput.CausesValidation = false;
            this.indepoQuantityInput.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indepoQuantityInput.Location = new System.Drawing.Point(40, 532);
            this.indepoQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.indepoQuantityInput.Name = "indepoQuantityInput";
            this.indepoQuantityInput.Size = new System.Drawing.Size(198, 47);
            this.indepoQuantityInput.TabIndex = 3;
            // 
            // addStockBttn
            // 
            this.addStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockBttn.Location = new System.Drawing.Point(40, 727);
            this.addStockBttn.Name = "addStockBttn";
            this.addStockBttn.Size = new System.Drawing.Size(453, 65);
            this.addStockBttn.TabIndex = 6;
            this.addStockBttn.Text = "Add Stock";
            this.addStockBttn.UseVisualStyleBackColor = true;
            this.addStockBttn.Click += new System.EventHandler(this.addStockBttn_Click);
            // 
            // departmentsCmbbxAddingStock
            // 
            this.departmentsCmbbxAddingStock.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsCmbbxAddingStock.FormattingEnabled = true;
            this.departmentsCmbbxAddingStock.Location = new System.Drawing.Point(40, 635);
            this.departmentsCmbbxAddingStock.Name = "departmentsCmbbxAddingStock";
            this.departmentsCmbbxAddingStock.Size = new System.Drawing.Size(453, 52);
            this.departmentsCmbbxAddingStock.TabIndex = 5;
            this.departmentsCmbbxAddingStock.Text = "Department";
            // 
            // inStoreQuantityInput
            // 
            this.inStoreQuantityInput.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStoreQuantityInput.Location = new System.Drawing.Point(298, 532);
            this.inStoreQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.inStoreQuantityInput.Name = "inStoreQuantityInput";
            this.inStoreQuantityInput.Size = new System.Drawing.Size(195, 47);
            this.inStoreQuantityInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "In store:";
            // 
            // pricePerItemTbx
            // 
            this.pricePerItemTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerItemTbx.Location = new System.Drawing.Point(40, 391);
            this.pricePerItemTbx.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricePerItemTbx.Name = "pricePerItemTbx";
            this.pricePerItemTbx.Size = new System.Drawing.Size(453, 47);
            this.pricePerItemTbx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price per item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name:";
            // 
            // descriptionTbx
            // 
            this.descriptionTbx.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTbx.Location = new System.Drawing.Point(40, 200);
            this.descriptionTbx.Name = "descriptionTbx";
            this.descriptionTbx.Size = new System.Drawing.Size(453, 107);
            this.descriptionTbx.TabIndex = 1;
            this.descriptionTbx.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 808);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricePerItemTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inStoreQuantityInput);
            this.Controls.Add(this.departmentsCmbbxAddingStock);
            this.Controls.Add(this.addStockBttn);
            this.Controls.Add(this.indepoQuantityInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStockNameTbx);
            this.Name = "AddStock";
            this.Text = "Add Stock";
            ((System.ComponentModel.ISupportInitialize)(this.indepoQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerItemTbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addStockNameTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown indepoQuantityInput;
        private System.Windows.Forms.Button addStockBttn;
        private System.Windows.Forms.ComboBox departmentsCmbbxAddingStock;
        private System.Windows.Forms.NumericUpDown inStoreQuantityInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pricePerItemTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descriptionTbx;
        private System.Windows.Forms.Label label5;
    }
}