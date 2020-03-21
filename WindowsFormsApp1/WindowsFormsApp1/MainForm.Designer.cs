﻿namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.btnViewRequests = new System.Windows.Forms.Button();
            this.btnHireEmployeeRequest = new System.Windows.Forms.Button();
            this.btnFireEmployeeRequest = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnFireManager = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnCreateAdminManager = new System.Windows.Forms.Button();
            this.stocksTab = new System.Windows.Forms.TabPage();
            this.requestStockBttn = new System.Windows.Forms.Button();
            this.viewStocksBttn = new System.Windows.Forms.Button();
            this.viewUpcomingShelfRestocksBttn = new System.Windows.Forms.Button();
            this.createStockBttn = new System.Windows.Forms.Button();
            this.departmentsTab = new System.Windows.Forms.TabPage();
            this.additionalDepartmentActionsBttn = new System.Windows.Forms.Button();
            this.addDepartmentBttn = new System.Windows.Forms.PictureBox();
            this.addNewDepartmentBttn = new System.Windows.Forms.PictureBox();
            this.flpDepartments = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.stocksTab.SuspendLayout();
            this.departmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDepartmentBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewDepartmentBttn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeesTab);
            this.tabControl1.Controls.Add(this.stocksTab);
            this.tabControl1.Controls.Add(this.departmentsTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.btnViewRequests);
            this.employeesTab.Controls.Add(this.btnHireEmployeeRequest);
            this.employeesTab.Controls.Add(this.btnFireEmployeeRequest);
            this.employeesTab.Controls.Add(this.btnSearchEmployee);
            this.employeesTab.Controls.Add(this.btnFireManager);
            this.employeesTab.Controls.Add(this.btnRemoveEmployee);
            this.employeesTab.Controls.Add(this.btnCreateAdminManager);
            this.employeesTab.Location = new System.Drawing.Point(4, 22);
            this.employeesTab.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.employeesTab.Size = new System.Drawing.Size(848, 374);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // btnViewRequests
            // 
            this.btnViewRequests.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRequests.Location = new System.Drawing.Point(25, 320);
            this.btnViewRequests.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewRequests.Name = "btnViewRequests";
            this.btnViewRequests.Size = new System.Drawing.Size(780, 53);
            this.btnViewRequests.TabIndex = 33;
            this.btnViewRequests.Text = "View requests";
            this.btnViewRequests.UseVisualStyleBackColor = true;
            this.btnViewRequests.Click += new System.EventHandler(this.BtnViewRequests_Click);
            // 
            // btnHireEmployeeRequest
            // 
            this.btnHireEmployeeRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHireEmployeeRequest.Location = new System.Drawing.Point(25, 17);
            this.btnHireEmployeeRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHireEmployeeRequest.Name = "btnHireEmployeeRequest";
            this.btnHireEmployeeRequest.Size = new System.Drawing.Size(780, 53);
            this.btnHireEmployeeRequest.TabIndex = 32;
            this.btnHireEmployeeRequest.Text = "Hire employee request";
            this.btnHireEmployeeRequest.UseVisualStyleBackColor = true;
            this.btnHireEmployeeRequest.Click += new System.EventHandler(this.BtnHireEmployeeRequest_Click);
            // 
            // btnFireEmployeeRequest
            // 
            this.btnFireEmployeeRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireEmployeeRequest.Location = new System.Drawing.Point(25, 175);
            this.btnFireEmployeeRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFireEmployeeRequest.Name = "btnFireEmployeeRequest";
            this.btnFireEmployeeRequest.Size = new System.Drawing.Size(780, 53);
            this.btnFireEmployeeRequest.TabIndex = 31;
            this.btnFireEmployeeRequest.Text = "Fire employee request";
            this.btnFireEmployeeRequest.UseVisualStyleBackColor = true;
            this.btnFireEmployeeRequest.Click += new System.EventHandler(this.BtnFireEmployeeRequest_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(25, 251);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(780, 53);
            this.btnSearchEmployee.TabIndex = 30;
            this.btnSearchEmployee.Text = "Search for employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnFireManager
            // 
            this.btnFireManager.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireManager.Location = new System.Drawing.Point(25, 175);
            this.btnFireManager.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFireManager.Name = "btnFireManager";
            this.btnFireManager.Size = new System.Drawing.Size(780, 53);
            this.btnFireManager.TabIndex = 29;
            this.btnFireManager.Text = "Fire manager";
            this.btnFireManager.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(25, 97);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(780, 53);
            this.btnRemoveEmployee.TabIndex = 28;
            this.btnRemoveEmployee.Text = "Remove employee from the system";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCreateAdminManager
            // 
            this.btnCreateAdminManager.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdminManager.Location = new System.Drawing.Point(25, 17);
            this.btnCreateAdminManager.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateAdminManager.Name = "btnCreateAdminManager";
            this.btnCreateAdminManager.Size = new System.Drawing.Size(780, 53);
            this.btnCreateAdminManager.TabIndex = 27;
            this.btnCreateAdminManager.Text = "Create admin/manager";
            this.btnCreateAdminManager.UseVisualStyleBackColor = true;
            this.btnCreateAdminManager.Click += new System.EventHandler(this.btnCreateAdminManager_Click);
            // 
            // stocksTab
            // 
            this.stocksTab.Controls.Add(this.requestStockBttn);
            this.stocksTab.Controls.Add(this.viewStocksBttn);
            this.stocksTab.Controls.Add(this.viewUpcomingShelfRestocksBttn);
            this.stocksTab.Controls.Add(this.createStockBttn);
            this.stocksTab.Location = new System.Drawing.Point(4, 22);
            this.stocksTab.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.stocksTab.Name = "stocksTab";
            this.stocksTab.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.stocksTab.Size = new System.Drawing.Size(848, 374);
            this.stocksTab.TabIndex = 1;
            this.stocksTab.Text = "Stocks";
            this.stocksTab.UseVisualStyleBackColor = true;
            // 
            // requestStockBttn
            // 
            this.requestStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestStockBttn.Location = new System.Drawing.Point(19, 177);
            this.requestStockBttn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.requestStockBttn.Name = "requestStockBttn";
            this.requestStockBttn.Size = new System.Drawing.Size(791, 53);
            this.requestStockBttn.TabIndex = 30;
            this.requestStockBttn.Text = "Request Stock";
            this.requestStockBttn.UseVisualStyleBackColor = true;
            this.requestStockBttn.Click += new System.EventHandler(this.requestStockBttn_Click);
            // 
            // viewStocksBttn
            // 
            this.viewStocksBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStocksBttn.Location = new System.Drawing.Point(19, 99);
            this.viewStocksBttn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.viewStocksBttn.Name = "viewStocksBttn";
            this.viewStocksBttn.Size = new System.Drawing.Size(791, 53);
            this.viewStocksBttn.TabIndex = 29;
            this.viewStocksBttn.Text = "View Stocks";
            this.viewStocksBttn.UseVisualStyleBackColor = true;
            this.viewStocksBttn.Click += new System.EventHandler(this.viewStocksBttn_Click);
            // 
            // viewUpcomingShelfRestocksBttn
            // 
            this.viewUpcomingShelfRestocksBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUpcomingShelfRestocksBttn.Location = new System.Drawing.Point(19, 22);
            this.viewUpcomingShelfRestocksBttn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.viewUpcomingShelfRestocksBttn.Name = "viewUpcomingShelfRestocksBttn";
            this.viewUpcomingShelfRestocksBttn.Size = new System.Drawing.Size(791, 52);
            this.viewUpcomingShelfRestocksBttn.TabIndex = 28;
            this.viewUpcomingShelfRestocksBttn.Text = "View upcoming shelf requests";
            this.viewUpcomingShelfRestocksBttn.UseVisualStyleBackColor = true;
            this.viewUpcomingShelfRestocksBttn.Click += new System.EventHandler(this.viewUpcomingShelfRestocksBttn_Click);
            // 
            // createStockBttn
            // 
            this.createStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStockBttn.Location = new System.Drawing.Point(19, 251);
            this.createStockBttn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createStockBttn.Name = "createStockBttn";
            this.createStockBttn.Size = new System.Drawing.Size(791, 60);
            this.createStockBttn.TabIndex = 27;
            this.createStockBttn.Text = "Create stock";
            this.createStockBttn.UseVisualStyleBackColor = true;
            this.createStockBttn.Click += new System.EventHandler(this.createStockBttn_Click);
            // 
            // departmentsTab
            // 
            this.departmentsTab.Controls.Add(this.additionalDepartmentActionsBttn);
            this.departmentsTab.Controls.Add(this.addDepartmentBttn);
            this.departmentsTab.Controls.Add(this.addNewDepartmentBttn);
            this.departmentsTab.Controls.Add(this.flpDepartments);
            this.departmentsTab.Controls.Add(this.label4);
            this.departmentsTab.Location = new System.Drawing.Point(4, 22);
            this.departmentsTab.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.departmentsTab.Name = "departmentsTab";
            this.departmentsTab.Size = new System.Drawing.Size(848, 374);
            this.departmentsTab.TabIndex = 2;
            this.departmentsTab.Text = "Departments";
            this.departmentsTab.UseVisualStyleBackColor = true;
            // 
            // additionalDepartmentActionsBttn
            // 
            this.additionalDepartmentActionsBttn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalDepartmentActionsBttn.Location = new System.Drawing.Point(555, 23);
            this.additionalDepartmentActionsBttn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.additionalDepartmentActionsBttn.Name = "additionalDepartmentActionsBttn";
            this.additionalDepartmentActionsBttn.Size = new System.Drawing.Size(194, 34);
            this.additionalDepartmentActionsBttn.TabIndex = 19;
            this.additionalDepartmentActionsBttn.Text = "Additional Actions";
            this.additionalDepartmentActionsBttn.UseVisualStyleBackColor = true;
            this.additionalDepartmentActionsBttn.Click += new System.EventHandler(this.additionalDepartmentActionsBttn_Click);
            // 
            // addDepartmentBttn
            // 
            this.addDepartmentBttn.Image = ((System.Drawing.Image)(resources.GetObject("addDepartmentBttn.Image")));
            this.addDepartmentBttn.Location = new System.Drawing.Point(774, 25);
            this.addDepartmentBttn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addDepartmentBttn.Name = "addDepartmentBttn";
            this.addDepartmentBttn.Size = new System.Drawing.Size(39, 32);
            this.addDepartmentBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addDepartmentBttn.TabIndex = 17;
            this.addDepartmentBttn.TabStop = false;
            this.addDepartmentBttn.Click += new System.EventHandler(this.addDepartmentBttn_Click);
            // 
            // addNewDepartmentBttn
            // 
            this.addNewDepartmentBttn.Location = new System.Drawing.Point(0, 0);
            this.addNewDepartmentBttn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addNewDepartmentBttn.Name = "addNewDepartmentBttn";
            this.addNewDepartmentBttn.Size = new System.Drawing.Size(67, 32);
            this.addNewDepartmentBttn.TabIndex = 18;
            this.addNewDepartmentBttn.TabStop = false;
            // 
            // flpDepartments
            // 
            this.flpDepartments.AutoScroll = true;
            this.flpDepartments.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpDepartments.Location = new System.Drawing.Point(30, 86);
            this.flpDepartments.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.flpDepartments.Name = "flpDepartments";
            this.flpDepartments.Size = new System.Drawing.Size(804, 283);
            this.flpDepartments.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Departments:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 407);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "Media Bazar";
            this.tabControl1.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.stocksTab.ResumeLayout(false);
            this.departmentsTab.ResumeLayout(false);
            this.departmentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDepartmentBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewDepartmentBttn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesTab;
        private System.Windows.Forms.TabPage stocksTab;
        private System.Windows.Forms.TabPage departmentsTab;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btnCreateAdminManager;

        private System.Windows.Forms.Button viewUpcomingShelfRestocksBttn;

        private System.Windows.Forms.Button createStockBttn;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnFireManager;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.FlowLayoutPanel flpDepartments;

        private System.Windows.Forms.Button btnFireEmployeeRequest;
        private System.Windows.Forms.Button btnHireEmployeeRequest;

        private System.Windows.Forms.Button requestStockBttn;
        private System.Windows.Forms.Button viewStocksBttn;

        private System.Windows.Forms.PictureBox addNewDepartmentBttn;
        private System.Windows.Forms.PictureBox addDepartmentBttn;
        private System.Windows.Forms.Button btnViewRequests;
        private System.Windows.Forms.Button additionalDepartmentActionsBttn;
    }
}