using GAP.Models;
using GAP.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class ClientRepository : IClientRepository
    {
        private InsuranceContext context;

        public ClientRepository(InsuranceContext _context)
        {
            context = _context;  
        }

        public bool DelClientById(int id)
        {
            bool accion = true;

            Client client = context.Client.FirstOrDefault(x => x.Id == id);

            if (client == null)
            {
                accion = false;
                return accion;
            }

            context.Client.Remove(client);
            context.SaveChanges();

            return accion;

        }

        public List<Client> GetAll()
        {
            return context.Client.ToList();
        }

        public Client GetByDocument(int documento)
        {
            return context.Client.FirstOrDefault(x => x.Document == documento);
        }

        public Client GetById(int id)
        {
            Client client = context.Client.FirstOrDefault(x => x.Id == id);

            return client;
        }

        public bool InsertClient(Client client)
        {
            context.Client.Add(client);
            context.SaveChanges();
            return true;

        }

        public bool UpdClientById(Client client)
        {
            context.Entry(client).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
    }
}
