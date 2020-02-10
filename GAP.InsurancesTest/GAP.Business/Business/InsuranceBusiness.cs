using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Businnes
{
    public class InsuranceBusiness : IInsuranceBusiness
    {
        private IInsuranceRepository _insuranceRepository;

        public InsuranceBusiness(IInsuranceRepository insuranceRepository)
        {
            _insuranceRepository = insuranceRepository;
        }


        public bool DelInsuranceById(int id)
        {
            return _insuranceRepository.DelInsuranceById(id);
        }

        public List<Insurance> GetAll()
        {
            return _insuranceRepository.GetAll();
        }

        public Insurance GetById(int id)
        {
            return _insuranceRepository.GetById(id);
        }

        public List<Insurance> GetInsuranceByClient(int id)
        {
            return _insuranceRepository.GetInsuranceByClient(id);
        }

        public bool InsertInsurance(Insurance insurance)
        {
            bool validationBusiness = false;
            CoveringType risk = _insuranceRepository.GetCoveringById(insurance.RiskTypeId);

            int riskType = insurance.RiskTypeId;

            if (riskType == 5 && risk.Percentage <= 50)
            {
                validationBusiness = _insuranceRepository.InsertInsurance(insurance);
            }

            return validationBusiness;
        }

        public bool UpdInsuranceById(Insurance insurance)
        {
            throw new NotImplementedException();
        }
    }
}
