using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Manage
    {
        public int IdClass { get; set; }
        public int IdStaff { get; set; }

        public virtual Decoclass IdClassNavigation { get; set; }
        public virtual staff IdStaffNavigation { get; set; }
    }
}
