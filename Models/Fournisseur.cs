using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Fournisseur
    {
        public Fournisseur()
        {
            Products = new HashSet<Product>();
        }

        public Fournisseur(string nameFourn, string addrFounr, int cpFounr, string cityFourn, string emailFounr)
        {
            NameFourn = nameFourn;
            AddrFounr = addrFounr;
            CpFounr = cpFounr;
            CityFourn = cityFourn;
            EmailFounr = emailFounr;
        }

        public int IdFourn { get; set; }
        public string NameFourn { get; set; }
        public string AddrFounr { get; set; }
        public int CpFounr { get; set; }
        public string CityFourn { get; set; }
        public string EmailFounr { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
