
namespace app_csharpBTS
{
    partial class ClassPage2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientName = new System.Windows.Forms.TextBox();
            this.remove_class = new System.Windows.Forms.Button();
            this.class_tab = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.add_class_btn = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Remove_cli = new System.Windows.Forms.Button();
            this.Add_cli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.member_tab = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cours = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Alertes = new System.Windows.Forms.Button();
            this.Stocks = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.clientName);
            this.panel2.Controls.Add(this.remove_class);
            this.panel2.Controls.Add(this.class_tab);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.add_class_btn);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Firstname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Remove_cli);
            this.panel2.Controls.Add(this.Add_cli);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.member_tab);
            this.panel2.Location = new System.Drawing.Point(265, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 697);
            this.panel2.TabIndex = 28;
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(44, 128);
            this.clientName.Name = "clientName";
            this.clientName.PlaceholderText = "Nom";
            this.clientName.Size = new System.Drawing.Size(140, 23);
            this.clientName.TabIndex = 35;
            this.clientName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            // 
            // remove_class
            // 
            this.remove_class.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove_class.Location = new System.Drawing.Point(139, 563);
            this.remove_class.Name = "remove_class";
            this.remove_class.Size = new System.Drawing.Size(225, 69);
            this.remove_class.TabIndex = 34;
            this.remove_class.Text = "retirer un cours";
            this.remove_class.UseVisualStyleBackColor = true;
            this.remove_class.Click += new System.EventHandler(this.remove_class_Click);
            // 
            // class_tab
            // 
            this.class_tab.FullRowSelect = true;
            this.class_tab.GridLines = true;
            this.class_tab.HideSelection = false;
            this.class_tab.Location = new System.Drawing.Point(877, 55);
            this.class_tab.Name = "class_tab";
            this.class_tab.Size = new System.Drawing.Size(382, 566);
            this.class_tab.TabIndex = 33;
            this.class_tab.UseCompatibleStateImageBehavior = false;
            this.class_tab.View = System.Windows.Forms.View.Details;
            this.class_tab.SelectedIndexChanged += new System.EventHandler(this.class_tab_SelectedIndexChanged);
            this.class_tab.DoubleClick += new System.EventHandler(this.class_tab_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(866, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 31;
            // 
            // add_class_btn
            // 
            this.add_class_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_class_btn.Location = new System.Drawing.Point(139, 472);
            this.add_class_btn.Name = "add_class_btn";
            this.add_class_btn.Size = new System.Drawing.Size(225, 69);
            this.add_class_btn.TabIndex = 32;
            this.add_class_btn.Text = "ajouter un cours";
            this.add_class_btn.UseVisualStyleBackColor = true;
            this.add_class_btn.Click += new System.EventHandler(this.add_class_btn_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(44, 190);
            this.email.Name = "email";
            this.email.PlaceholderText = "email";
            this.email.Size = new System.Drawing.Size(140, 23);
            this.email.TabIndex = 30;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 29;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(287, 128);
            this.Firstname.Name = "Firstname";
            this.Firstname.PlaceholderText = "Prenom";
            this.Firstname.Size = new System.Drawing.Size(182, 23);
            this.Firstname.TabIndex = 28;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 27;
            // 
            // Remove_cli
            // 
            this.Remove_cli.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Remove_cli.Location = new System.Drawing.Point(111, 383);
            this.Remove_cli.Name = "Remove_cli";
            this.Remove_cli.Size = new System.Drawing.Size(278, 69);
            this.Remove_cli.TabIndex = 26;
            this.Remove_cli.Text = "retirer un client du cours";
            this.Remove_cli.UseVisualStyleBackColor = true;
            this.Remove_cli.Click += new System.EventHandler(this.Remove_cli_Click);
            // 
            // Add_cli
            // 
            this.Add_cli.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_cli.Location = new System.Drawing.Point(111, 294);
            this.Add_cli.Name = "Add_cli";
            this.Add_cli.Size = new System.Drawing.Size(278, 69);
            this.Add_cli.TabIndex = 25;
            this.Add_cli.Text = "ajouter un client au cours";
            this.Add_cli.UseVisualStyleBackColor = true;
            this.Add_cli.Click += new System.EventHandler(this.Add_cli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(31, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 41);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Cours";
            // 
            // member_tab
            // 
            this.member_tab.FullRowSelect = true;
            this.member_tab.GridLines = true;
            this.member_tab.HideSelection = false;
            this.member_tab.Location = new System.Drawing.Point(498, 55);
            this.member_tab.Name = "member_tab";
            this.member_tab.Size = new System.Drawing.Size(382, 566);
            this.member_tab.TabIndex = 0;
            this.member_tab.UseCompatibleStateImageBehavior = false;
            this.member_tab.View = System.Windows.Forms.View.Details;
            this.member_tab.SelectedIndexChanged += new System.EventHandler(this.member_tab_SelectedIndexChanged);
            this.member_tab.DoubleClick += new System.EventHandler(this.member_tab_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.cours);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Alertes);
            this.panel1.Controls.Add(this.Stocks);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 697);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cours
            // 
            this.cours.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cours.Location = new System.Drawing.Point(22, 349);
            this.cours.Name = "cours";
            this.cours.Size = new System.Drawing.Size(225, 69);
            this.cours.TabIndex = 6;
            this.cours.Text = "Cours";
            this.cours.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(49, 603);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(174, 46);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(61, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 60);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "DecoStock";
            // 
            // Alertes
            // 
            this.Alertes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alertes.Location = new System.Drawing.Point(22, 238);
            this.Alertes.Name = "Alertes";
            this.Alertes.Size = new System.Drawing.Size(225, 69);
            this.Alertes.TabIndex = 1;
            this.Alertes.Text = "Alertes";
            this.Alertes.UseVisualStyleBackColor = true;
            // 
            // Stocks
            // 
            this.Stocks.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stocks.Location = new System.Drawing.Point(22, 133);
            this.Stocks.Name = "Stocks";
            this.Stocks.Size = new System.Drawing.Size(225, 69);
            this.Stocks.TabIndex = 0;
            this.Stocks.Text = "Stocks";
            this.Stocks.UseVisualStyleBackColor = true;
            this.Stocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // ClassPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClassPage2";
            this.Text = "ClassPage";
            this.Load += new System.EventHandler(this.ClassPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button remove_class;
        private System.Windows.Forms.ListView class_tab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_class_btn;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Remove_cli;
        private System.Windows.Forms.Button Add_cli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView member_tab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cours;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Alertes;
        private System.Windows.Forms.Button Stocks;
        private System.Windows.Forms.TextBox clientName;
    }
}