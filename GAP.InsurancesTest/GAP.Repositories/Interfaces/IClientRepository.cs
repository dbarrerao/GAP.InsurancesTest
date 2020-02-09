using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetByDocument(int documento);
        Client GetById(int id);
        void InsertClient(Client client);
        bool UpdClientById(Client client);
        bool DelClientById(int id);
    }
}
