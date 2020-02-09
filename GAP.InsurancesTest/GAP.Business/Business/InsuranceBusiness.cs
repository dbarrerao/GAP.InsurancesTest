using GAP.Business.Interfaces;
using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Businnes
{
    public class InsuranceBusiness : IInsuranceBusiness
    {
        private IInsuranceBusiness _insuranceBusiness;

        public InsuranceBusiness(IInsuranceBusiness insuranceBusiness)
        {
            _insuranceBusiness = insuranceBusiness;
        }

        public bool DelInsuranceById(int id)
        {
            return _insuranceBusiness.DelInsuranceById(id);
        }

        public List<Insurance> GetAll()
        {
            return _insuranceBusiness.GetAll();
        }

        public Insurance GetById(int id)
        {
            return _insuranceBusiness.GetById(id);
        }

        public List<Insurance> GetInsuranceByClient(int id)
        {
            return _insuranceBusiness.GetInsuranceByClient(id);
        }

        public bool InsertInsurance(Insurance insurance)
        {
            return _insuranceBusiness.InsertInsurance(insurance);
        }

        public bool UpdInsuranceById(Insurance insurance)
        {
            throw new NotImplementedException();
        }
    }
}
