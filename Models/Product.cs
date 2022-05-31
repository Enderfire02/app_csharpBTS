using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Product
    {
        public Product()
        {
            Organizes = new HashSet<Organize>();
        }

        public Product(string nameProduct, string typeProduct, int priceProduct, int stockProduct)
        {
            NameProduct = nameProduct;
            TypeProduct = typeProduct;
            PriceProduct = priceProduct;
            StockProduct = stockProduct;
            
        }

        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string TypeProduct { get; set; }
        public int PriceProduct { get; set; }
        public int StockProduct { get; set; }
        public int IdFourn { get; set; }

        public virtual Fournisseur IdFournNavigation { get; set; }
        public virtual ICollection<Organize> Organizes { get; set; }
    }
}
