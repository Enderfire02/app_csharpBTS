using app_csharpBTS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_csharpBTS.Manager
{
    class FournisseurManager : DataManager
    {
        public List<Fournisseur> AllFourn()
        {
            var list = Context.Fournisseurs.AsQueryable();
            return list.ToList();
        }

        public Fournisseur FindFournisseurName(string name)
             => Context.Fournisseurs.FirstOrDefault(fournisseur => fournisseur.NameFourn == name);

        public Fournisseur FindFournisseurID (int id)
        {
            return Context.Fournisseurs.Find(id);
        }
       
    }
}
