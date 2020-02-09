using GAP.Models;
using GAP.Repositories.Interfaces;
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

        public void DelClientById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            return context.Client.ToList();
        }

        public Client GetByDocument(int documento)
        {
            return context.Client.Find(documento);
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertClient(Client client)
        {
            throw new NotImplementedException();
        }

        public Client UpdClientById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
