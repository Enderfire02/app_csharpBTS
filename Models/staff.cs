using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class staff
    {
        public staff()
        {
            Manages = new HashSet<Manage>();
            Organizes = new HashSet<Organize>();
        }

        public int IdStaff { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Manage> Manages { get; set; }
        public virtual ICollection<Organize> Organizes { get; set; }
    }
}
