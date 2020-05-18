namespace MediaBazar
{
    partial class RulesEditor
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
            this.rulesLv = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.AddRulebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeleteId = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesLv
            // 
            this.rulesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Rule});
            this.rulesLv.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLv.HideSelection = false;
            this.rulesLv.Location = new System.Drawing.Point(12, 12);
            this.rulesLv.Name = "rulesLv";
            this.rulesLv.Size = new System.Drawing.Size(547, 195);
            this.rulesLv.TabIndex = 4;
            this.rulesLv.UseCompatibleStateImageBehavior = false;
            this.rulesLv.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 38;
            // 
            // Rule
            // 
            this.Rule.Text = "Rule";
            this.Rule.Width = 497;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rule description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(12, 239);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(547, 64);
            this.tbDescription.TabIndex = 11;
            // 
            // AddRulebtn
            // 
            this.AddRulebtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRulebtn.Location = new System.Drawing.Point(12, 309);
            this.AddRulebtn.Name = "AddRulebtn";
            this.AddRulebtn.Size = new System.Drawing.Size(292, 33);
            this.AddRulebtn.TabIndex = 12;
            this.AddRulebtn.Text = "Add Rule";
            this.AddRulebtn.UseVisualStyleBackColor = true;
            this.AddRulebtn.Click += new System.EventHandler(this.AddRulebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id:";
            // 
            // tbDeleteId
            // 
            this.tbDeleteId.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeleteId.Location = new System.Drawing.Point(355, 316);
            this.tbDeleteId.Name = "tbDeleteId";
            this.tbDeleteId.Size = new System.Drawing.Size(100, 23);
            this.tbDeleteId.TabIndex = 14;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(461, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(98, 33);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // RulesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 350);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.tbDeleteId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRulebtn);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rulesLv);
            this.Name = "RulesEditor";
            this.Text = "RulesEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView rulesLv;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Rule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button AddRulebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeleteId;
        private System.Windows.Forms.Button deleteBtn;
    }
}