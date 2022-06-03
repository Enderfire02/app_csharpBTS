
using app_csharpBTS;
using app_csharpBTS.Manager;
using app_csharpBTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_Csharp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        Product product = new Product();
        ProductManager productManager = new ProductManager();
        FournisseurManager fournisseurManager = new FournisseurManager();
        private Fournisseur FournisseurSelected;
        private Product ProductSelected;
        
        #region affichage produits dans listview
        private void HomePage_Load(object sender, EventArgs e)
        {
            ProductList.Items.Clear();
            foreach (Product product in productManager.AllProducts())
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    product.NameProduct.ToString(),
                    product.TypeProduct.ToString(),
                    product.StockProduct.ToString(),
                    product.PriceProduct.ToString(),
                    product.IdFournNavigation.NameFourn.ToString(),

                    
                });
                lvi.Tag = product;
                ProductList.Items.Add(lvi);
            }
            ProductList.Columns.Clear();
            ProductList.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Type", Text = "Type", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Stock", Text = "Stock", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Prix", Text = "Prix", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Nom Fournisseur", Text = "Nom Fournisseur", Width = 250 });
        }
        #endregion
        
        private void HomePageB_load()
        {
            foreach (Product product in productManager.AllProducts())
            {
                ListViewItem lvi = new ListViewItem(new string[]
               {
                   product.IdProduct.ToString(),
                   product.NameProduct.ToString(),
                    product.StockProduct.ToString(),
                    product.PriceProduct.ToString(),
                    
                });
                lvi.Tag = product;
                ProductList.Items.Add(lvi);
            }
            ProductList.Columns.Clear();
            ProductList.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Type", Text = "Type", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Stock", Text = "Stock", Width = 250 });
            ProductList.Columns.Add(new ColumnHeader() { Name = "Prix", Text = "Prix", Width = 250 });
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_product_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Type.Text))
            {
                MessageBox.Show("Oups !! il semblerai que vous avez oublié de renseigner certains champs");

;
            }
            else
            {

                Product product = new Product((int)id.Value,Name.Text, Type.Text, (int)Price.Value, (int)Stock.Value);
                productManager.AddProduct(product);

                ProductList.Items.Clear();
                ProductList.Columns.Clear();
                ProductList.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Type", Text = "Type", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Stock", Text = "Stock", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Prix", Text = "Prix", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Nom Fournisseur", Text = "Nom Fournisseur", Width = 250 });
                foreach (Product productAff in productManager.AllProducts())
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                    productAff.NameProduct.ToString(),
                    productAff.TypeProduct.ToString(),
                    productAff.StockProduct.ToString(),
                    productAff.PriceProduct.ToString(),
                    productAff.IdFournNavigation.NameFourn.ToString(),


                    });
                    lvi.Tag = productAff;
                    ProductList.Items.Add(lvi);
                }
                
            }
        }

        private void Remove_product_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Type.Text) || ProductSelected == null)
            {
                MessageBox.Show("Il semblerai que vous avez pas sélectionné de champs");
            }
            else
            {
                productManager.RemoveProduct(ProductSelected);

                ProductList.Items.Clear();
                ProductList.Columns.Clear();
                ProductList.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Type", Text = "Type", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Stock", Text = "Stock", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Prix", Text = "Prix", Width = 250 });
                ProductList.Columns.Add(new ColumnHeader() { Name = "Nom Fournisseur", Text = "Nom Fournisseur", Width = 250 });
                foreach (Product productAff in productManager.AllProducts())
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                    productAff.NameProduct.ToString(),
                    productAff.TypeProduct.ToString(),
                    productAff.StockProduct.ToString(),
                    productAff.PriceProduct.ToString(),
                    productAff.IdFournNavigation.NameFourn.ToString(),


                    });
                    lvi.Tag = productAff;
                    ProductList.Items.Add(lvi);
                }
            }
            HomePage page = new HomePage();
            page.Show();
        }

        //private void add_quantity_Click(object sender, EventArgs e)
        //{

        //}

        //private void less_quantity_Click(object sender, EventArgs e)
        //{

        //}

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            ClassPage2 form = new ClassPage2();
            form.Show();
            
            
        }

        private void Alertes_Click(object sender, EventArgs e)
        {

        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            
        }
      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductList_DoubleClick(object sender, EventArgs e)
        {
            
                ListView.SelectedListViewItemCollection selected = ProductList.SelectedItems;
                if (selected.Count == 1)
                {
                    ProductSelected = selected[0].Tag as Product;

                    id.Value = ProductSelected.IdProduct;
                    Name.Text = ProductSelected.NameProduct;
                    Type.Text = ProductSelected.TypeProduct;
                    Stock.Value = ProductSelected.StockProduct;
                    Price.Value = ProductSelected.PriceProduct;
                }
            
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Type.Text))
            {
                MessageBox.Show("Il semblerai que vous avez pas sélectionné de champs");
            }
            else
            {
             
                productManager.EditProduct((int)id.Value, Name.Text, Type.Text, (int)Price.Value, (int)Stock.Value);
            }
            HomePage page = new HomePage();
            page.Show();
         
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductList_Click(object sender, EventArgs e)
        {
           
         
            
            
        }

        private void FounrData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Staffid_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
