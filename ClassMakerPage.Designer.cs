
namespace BTS_Csharp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameClassText = new System.Windows.Forms.TextBox();
            this.PlaceClassText = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter un cours ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameClassText
            // 
            this.NameClassText.Location = new System.Drawing.Point(124, 116);
            this.NameClassText.Name = "NameClassText";
            this.NameClassText.PlaceholderText = "Nom";
            this.NameClassText.Size = new System.Drawing.Size(152, 23);
            this.NameClassText.TabIndex = 3;
            // 
            // PlaceClassText
            // 
            this.PlaceClassText.Location = new System.Drawing.Point(356, 116);
            this.PlaceClassText.Name = "PlaceClassText";
            this.PlaceClassText.PlaceholderText = "Lieu";
            this.PlaceClassText.Size = new System.Drawing.Size(152, 23);
            this.PlaceClassText.TabIndex = 4;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(228, 164);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(48, 23);
            this.Stock.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "animateur :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(652, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.PlaceClassText);
            this.Controls.Add(this.NameClassText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NameClassText;
        private System.Windows.Forms.TextBox PlaceClassText;
        private System.Windows.Forms.NumericUpDown Stock;
        private System.Windows.Forms.Label label2;
    }
}