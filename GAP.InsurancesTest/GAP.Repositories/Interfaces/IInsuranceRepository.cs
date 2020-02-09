using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface IInsuranceRepository
    {
        List<Insurance> GetAll();
        Insurance GetById(int id);
        List<Insurance> GetInsuranceByClient(int document);
        bool UpdInsuranceById(Client client);
        bool DelInsuranceById(int id);
    }
}
