
using app_csharpBTS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_csharpBTS.Manager
{
    class ClientManager : DataManager
    {
        public Client AddClient(Client client)
        {
            Context.Clients.Add(client);
            if (Context.SaveChanges() > 0)
                return client;
            return null;
        }
        public bool RemoveClient(Client client)
        {
            if (client != null)
            {
                Context.Clients.Remove(client);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool RemoveClient(int idClient)
        {
            Client client = FindClientID(idClient);
            if (client == null)
                return false;
            return RemoveClient(client);
        }
        public bool EditClient(Client client)
        {
            Context.Entry(client).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }
        public Client FindClientID(int idClient)
        {
            return Context.Clients.Find(idClient);
        }
        public Client FindClientName(string NameCli)
            => Context.Clients.FirstOrDefault(client => client.NameCli == NameCli);
        public List<Client> GetClients()
            => Context.Clients.ToList();
        
    }
}
