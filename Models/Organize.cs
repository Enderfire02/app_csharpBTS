using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Organize
    {
        public int IdProduct { get; set; }
        public int IdStaff { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual staff IdStaffNavigation { get; set; }
    }
}
