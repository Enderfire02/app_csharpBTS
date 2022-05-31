using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class staff
    {
        public staff()
        {
            Decoclasses = new HashSet<Decoclass>();
            Organizes = new HashSet<Organize>();
        }

        public int IdStaff { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Decoclass> Decoclasses { get; set; }
        public virtual ICollection<Organize> Organizes { get; set; }
    }
}
