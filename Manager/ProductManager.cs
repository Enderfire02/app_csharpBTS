using app_csharpBTS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_csharpBTS.Manager
{
    class ProductManager : DataManager
    {
        public Product AddProduct(Product product)
        {
            Context.Products.Add(product);
            if (Context.SaveChanges() > 0)
                return product;
            return null;
        }
        public bool RemoveProduct(Product product)
        {
            if (product != null)
            {
                Context.Products.Remove(product);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool RemoveProduct(int idProduct)
        {
            Product product = FindProductID(idProduct);
            if (product == null)
                return false;
            return RemoveProduct(product);
        }
        public void EditProduct(int id, string Name, string Type, int price, int Stock)
        {
            

            Models.Product product = FindProductID(id);
            if (product.NameProduct != Name)
                product.NameProduct = Name;
            Context.SaveChanges();
            if (product.TypeProduct != Type)
                product.TypeProduct = Type;
            Context.SaveChanges();
            if (product.PriceProduct != price)
                product.PriceProduct = price;
            Context.SaveChanges();
            if (product.StockProduct != Stock)
                product.StockProduct = Stock;
            Context.SaveChanges();


        }
        public Product FindProductID(int idProduct)
        {
            return Context.Products.Find(idProduct);
        }
        public Product FindProductName(string NameProduct)
            => Context.Products.FirstOrDefault(product => product.NameProduct == NameProduct);
        public List<Product> GetProducts()
            => Context.Products.ToList();
        public List<Product> AllProducts() 
        {
            var list = Context.Products.Include(p => p.IdFournNavigation).AsQueryable();
            return list.ToList();
        }
    }
}
