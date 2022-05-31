using app_csharpBTS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_csharpBTS.Manager
{
    class PartakesManager : DataManager
    {
        public List<Partake> FindClassClient(int id)
        {
            var list = Context.Partakes.Include(l => l.IdCliNavigation).AsQueryable();
            list = list.Where(x => x.IdClass == id);
            return list.ToList();
        }
        public Partake AddPartake(Partake partake)
        {
            Context.Partakes.Add(partake);
            if (Context.SaveChanges() > 0)
                return partake;
            return null;
        }

     

        private Partake FindMemberID(int idClient)
        {
            return Context.Partakes.Find(idClient);
        }
    }
}
