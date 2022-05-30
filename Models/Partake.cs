using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Partake
    {
        public int IdClass { get; set; }
        public int IdCli { get; set; }

        public virtual Decoclass IdClassNavigation { get; set; }
        public virtual Client IdCliNavigation { get; set; }
    }
}
