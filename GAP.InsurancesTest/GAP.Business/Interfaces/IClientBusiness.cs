using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Interfaces
{
    public interface IClientBusiness
    {        
        List<Client> GetAll();       
        Client GetByDocument(string documento);
        Client UpdClientById(int id);
        void DelClientById(int id);        
    }
}
