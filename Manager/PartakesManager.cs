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
        public bool RemoveParticipation(Partake partake)
        {
            if (partake != null)
            {
                Context.Partakes.Remove(partake);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool RemoveParticipation(int idClient)
        {
            Partake partake = FindMemberID(idClient);
            if (partake == null)
                return false;
            return RemoveParticipation(partake);
        }
        public bool RemoveParticipation(int idClass, int idClient)
        {
            var relation = Context.Partakes.Where(f => f.IdClass == idClass && f.IdCli == idClient).FirstOrDefault();
            if (relation != null)
            {
                Context.Partakes.Remove(relation);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }

        private Partake FindMemberID(int idClient)
        {
            return Context.Partakes.Find(idClient);
        }
    }
}
