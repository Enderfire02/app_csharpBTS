using app_csharpBTS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app_csharpBTS.Manager
{
    class classManager : DataManager
    {
        public Decoclass AddClass(Decoclass decoclass)
        {
            Context.Decoclasses.Add(decoclass);
            if (Context.SaveChanges() > 0)
                return decoclass;
            return null;
        }
        public bool RemoveClass(Decoclass decoclass)
        {
            if (decoclass != null)
            {
                Context.Decoclasses.Remove(decoclass);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool RemoveClass(int idClass)
        {
            Decoclass decoclass= FindClassID(idClass);
            if (decoclass== null)
                return false;
            return RemoveClass(decoclass);
        }

        private Decoclass FindClassID(int idClass)
        {
            return Context.Decoclasses.Find(idClass);
        }

        public List<Decoclass> RechercherClassName(string NameClass)
        {
            var liste = Context.Decoclasses.Where(Class => Class.NameClass.StartsWith(NameClass));
            return liste.ToList();
        }



        public bool EditClass(Decoclass Class)
        {
            Context.Entry(Class).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }

        public List<Decoclass> GetClasses()
                    => Context.Decoclasses.ToList();
        public List<Decoclass> AllClasses()
        {
            var list = Context.Decoclasses.AsQueryable();
            return list.ToList();
        }
    }
}
