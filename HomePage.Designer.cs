
namespace BTS_Csharp
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Stocks = new System.Windows.Forms.Button();
            this.Alertes = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_product = new System.Windows.Forms.Button();
            this.Remove_product = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StocksLabel = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ListView();
            this.Stock = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // Stocks
            // 
            this.Stocks.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stocks.Location = new System.Drawing.Point(10, 115);
            this.Stocks.Name = "Stocks";
            this.Stocks.Size = new System.Drawing.Size(225, 69);
            this.Stocks.TabIndex = 0;
            this.Stocks.Text = "Stocks";
            this.Stocks.UseVisualStyleBackColor = true;
            this.Stocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // Alertes
            // 
            this.Alertes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alertes.Location = new System.Drawing.Point(10, 207);
            this.Alertes.Name = "Alertes";
            this.Alertes.Size = new System.Drawing.Size(225, 69);
            this.Alertes.TabIndex = 1;
            this.Alertes.Text = "Alertes";
            this.Alertes.UseVisualStyleBackColor = true;
            this.Alertes.Click += new System.EventHandler(this.Alertes_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(37, 490);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(174, 46);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(37, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 60);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "DecoStock";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.Clients);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Alertes);
            this.panel1.Controls.Add(this.Stocks);
            this.panel1.Location = new System.Drawing.Point(2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 643);
            this.panel1.TabIndex = 4;
            // 
            // Clients
            // 
            this.Clients.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clients.Location = new System.Drawing.Point(10, 297);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(225, 69);
            this.Clients.TabIndex = 5;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1106, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 11;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Add_product
            // 
            this.Add_product.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_product.Location = new System.Drawing.Point(112, 543);
            this.Add_product.Name = "Add_product";
            this.Add_product.Size = new System.Drawing.Size(226, 69);
            this.Add_product.TabIndex = 13;
            this.Add_product.Text = "ajouter un produit";
            this.Add_product.UseVisualStyleBackColor = true;
            this.Add_product.Click += new System.EventHandler(this.Add_product_Click);
            // 
            // Remove_product
            // 
            this.Remove_product.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Remove_product.Location = new System.Drawing.Point(371, 543);
            this.Remove_product.Name = "Remove_product";
            this.Remove_product.Size = new System.Drawing.Size(225, 69);
            this.Remove_product.TabIndex = 14;
            this.Remove_product.Text = "supprimer un produit";
            this.Remove_product.UseVisualStyleBackColor = true;
            this.Remove_product.Click += new System.EventHandler(this.Remove_product_Click);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(273, 487);
            this.Type.Name = "Type";
            this.Type.PlaceholderText = "Type";
            this.Type.Size = new System.Drawing.Size(182, 23);
            this.Type.TabIndex = 16;
            this.Type.TextChanged += new System.EventHandler(this.Type_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 18;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Change.Location = new System.Drawing.Point(629, 543);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(225, 69);
            this.Change.TabIndex = 21;
            this.Change.Text = "Modifier un produit";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Name);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.StocksLabel);
            this.panel2.Controls.Add(this.ProductList);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Change);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Type);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Remove_product);
            this.panel2.Controls.Add(this.Add_product);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Stock);
            this.panel2.Controls.Add(this.Price);
            this.panel2.Location = new System.Drawing.Point(252, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 637);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Rechercher un produit";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(371, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Nom du produit ";
            this.textBox2.Size = new System.Drawing.Size(290, 23);
            this.textBox2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prix :";
            // 
            // StocksLabel
            // 
            this.StocksLabel.AutoSize = true;
            this.StocksLabel.Location = new System.Drawing.Point(517, 490);
            this.StocksLabel.Name = "StocksLabel";
            this.StocksLabel.Size = new System.Drawing.Size(47, 15);
            this.StocksLabel.TabIndex = 25;
            this.StocksLabel.Text = "Stocks :";
            this.StocksLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductList.FullRowSelect = true;
            this.ProductList.HideSelection = false;
            this.ProductList.Location = new System.Drawing.Point(47, 90);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(982, 364);
            this.ProductList.TabIndex = 22;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            this.ProductList.DoubleClick += new System.EventHandler(this.ProductList_DoubleClick);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(564, 487);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(182, 23);
            this.Stock.TabIndex = 23;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(843, 487);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(186, 23);
            this.Price.TabIndex = 24;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(47, 487);
            this.Name.Name = "Name";
            this.Name.PlaceholderText = "Nom";
            this.Name.Size = new System.Drawing.Size(180, 23);
            this.Name.TabIndex = 31;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1325, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //this.Name = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stocks;
        private System.Windows.Forms.Button Alertes;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_product;
        private System.Windows.Forms.Button Remove_product;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown Stock;
        private System.Windows.Forms.Label StocksLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Name;
    }
}

