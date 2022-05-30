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
        public bool EditProduct(Product product)
        {
            Context.Entry(product).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
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
            var list = Context.Products.AsQueryable();
            return list.ToList();
        }
    }
}
