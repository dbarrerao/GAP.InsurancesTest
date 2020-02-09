using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Businnes
{
    public class ClientBusiness : IClientBusiness
    {

        private IClientRepository clientRepository;

        public ClientBusiness(IClientRepository _clientRepository)
        {
            clientRepository = _clientRepository;
        }

        public bool DelClientById(int id)
        {
            return clientRepository.DelClientById(id);
        }

        public List<Client> GetAll()
        {
            return clientRepository.GetAll();
        }

        public Client GetByDocument(int documento)
        {
            return clientRepository.GetByDocument(documento);
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdClientById(Client client)
        {
            return clientRepository.UpdClientById(client);
        }

        public bool InsertClient(Client client)
        {
            return clientRepository.InsertClient(client);
        }
    }
}
