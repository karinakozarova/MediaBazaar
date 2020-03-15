namespace WindowsFormsApp1
{
    partial class DepartmentUserControl
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentDescription = new System.Windows.Forms.Label();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(14, 14);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(271, 33);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDepartmentDescription
            // 
            this.lblDepartmentDescription.AutoSize = true;
            this.lblDepartmentDescription.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentDescription.Location = new System.Drawing.Point(16, 47);
            this.lblDepartmentDescription.Name = "lblDepartmentDescription";
            this.lblDepartmentDescription.Size = new System.Drawing.Size(217, 20);
            this.lblDepartmentDescription.TabIndex = 1;
            this.lblDepartmentDescription.Text = "Department description";
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartment.Location = new System.Drawing.Point(342, 59);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(70, 66);
            this.btnEditDepartment.TabIndex = 2;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.BtnEditDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDepartment.Location = new System.Drawing.Point(418, 59);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(70, 66);
            this.btnRemoveDepartment.TabIndex = 3;
            this.btnRemoveDepartment.Text = "Remove";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.BtnRemoveDepartment_Click);
            // 
            // DepartmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.lblDepartmentDescription);
            this.Controls.Add(this.lblDepartmentName);
            this.Name = "DepartmentUserControl";
            this.Size = new System.Drawing.Size(491, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentDescription;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnRemoveDepartment;
    }
}
