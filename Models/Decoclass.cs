using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Decoclass
    {
        public Decoclass()
        {
            Partakes = new HashSet<Partake>();
        }

        public int IdClass { get; set; }
        public string PlaceClass { get; set; }
        public string NameClass { get; set; }
        public int IdStaff { get; set; }

        public virtual staff IdStaffNavigation { get; set; }
        public virtual ICollection<Partake> Partakes { get; set; }
    }
}
