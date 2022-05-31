using System;
using System.Collections.Generic;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class Client
    {
        public Client()
        {
            Partakes = new HashSet<Partake>();
        }

        public Client(string nameCli, string firstnameCli, string emailCli)
        {
            NameCli = nameCli;
            FirstnameCli = firstnameCli;
            EmailCli = emailCli;
        }

        public int IdCli { get; set; }
        public string NameCli { get; set; }
        public string FirstnameCli { get; set; }
        public string EmailCli { get; set; }

        public virtual ICollection<Partake> Partakes { get; set; }
    }
}
