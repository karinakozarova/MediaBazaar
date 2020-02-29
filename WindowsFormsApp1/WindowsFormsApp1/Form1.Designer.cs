namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.mediaBazarLogoLogin = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.loginBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBazarLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your credentials";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(56, 226);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(498, 46);
            this.Username.TabIndex = 1;
            // 
            // mediaBazarLogoLogin
            // 
            this.mediaBazarLogoLogin.Image = global::WindowsFormsApp1.Properties.Resources.DigitalTech_Logo_3;
            this.mediaBazarLogoLogin.Location = new System.Drawing.Point(620, 12);
            this.mediaBazarLogoLogin.Margin = new System.Windows.Forms.Padding(0);
            this.mediaBazarLogoLogin.Name = "mediaBazarLogoLogin";
            this.mediaBazarLogoLogin.Size = new System.Drawing.Size(567, 531);
            this.mediaBazarLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediaBazarLogoLogin.TabIndex = 2;
            this.mediaBazarLogoLogin.TabStop = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(56, 354);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(498, 46);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // loginBttn
            // 
            this.loginBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBttn.Location = new System.Drawing.Point(92, 469);
            this.loginBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(428, 74);
            this.loginBttn.TabIndex = 4;
            this.loginBttn.Text = "Login";
            this.loginBttn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBttn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.mediaBazarLogoLogin);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Media Bazar";
            ((System.ComponentModel.ISupportInitialize)(this.mediaBazarLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.PictureBox mediaBazarLogoLogin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

