
namespace BTS_Csharp
{
    partial class LoginPage
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
            this.Login = new System.Windows.Forms.Button();
            this.login_text = new System.Windows.Forms.Label();
            this.Password_text = new System.Windows.Forms.Label();
            this.USN = new System.Windows.Forms.TextBox();
            this.PWD = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(202, 189);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(113, 53);
            this.Login.TabIndex = 0;
            this.Login.Text = "Se connecter";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Location = new System.Drawing.Point(111, 108);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(43, 15);
            this.login_text.TabIndex = 1;
            this.login_text.Text = "Login :";
            this.login_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password_text
            // 
            this.Password_text.AutoSize = true;
            this.Password_text.Location = new System.Drawing.Point(94, 142);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(60, 15);
            this.Password_text.TabIndex = 2;
            this.Password_text.Text = "Password:";
            // 
            // USN
            // 
            this.USN.Location = new System.Drawing.Point(170, 105);
            this.USN.Name = "USN";
            this.USN.Size = new System.Drawing.Size(181, 23);
            this.USN.TabIndex = 3;
            this.USN.TextChanged += new System.EventHandler(this.USN_TextChanged);
            // 
            // PWD
            // 
            this.PWD.Location = new System.Drawing.Point(170, 142);
            this.PWD.Name = "PWD";
            this.PWD.Size = new System.Drawing.Size(181, 23);
            this.PWD.TabIndex = 4;
            this.PWD.UseSystemPasswordChar = true;
            this.PWD.TextChanged += new System.EventHandler(this.PWD_TextChanged);
            // 
            // Name_text
            // 
            this.Name_text.AutoSize = true;
            this.Name_text.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_text.Location = new System.Drawing.Point(164, 22);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(187, 60);
            this.Name_text.TabIndex = 5;
            this.Name_text.Text = "DecoStock";
            this.Name_text.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(501, 336);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.PWD);
            this.Controls.Add(this.USN);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.Label Password_text;
        private System.Windows.Forms.TextBox USN;
        private System.Windows.Forms.TextBox PWD;
        private System.Windows.Forms.Label Name_text;
    }
}