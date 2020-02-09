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

        public void DelClientById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            return clientRepository.GetAll();
        }

        public Client GetByDocument(string documento)
        {
            return clientRepository.GetByDocument(documento);
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdClientById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
