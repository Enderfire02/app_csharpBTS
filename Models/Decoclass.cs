using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Decoclass
    {
        public Decoclass()
        {
            Manages = new HashSet<Manage>();
            Partakes = new HashSet<Partake>();
        }

        public Decoclass(string placeClass, string nameClass)
        {
            PlaceClass = placeClass;
            NameClass = nameClass;
        }

        public int IdClass { get; set; }
        public string PlaceClass { get; set; }
        public string NameClass { get; set; }

        public virtual ICollection<Manage> Manages { get; set; }
        public virtual ICollection<Partake> Partakes { get; set; }
    }
}
