using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private InsuranceContext _context;
        public InsuranceRepository(InsuranceContext context)
        {
            _context = context; 
        }
        
        public bool DelInsuranceById(int id)
        {
            bool result = true;

            Insurance insurance = _context.Insurance.FirstOrDefault(x => x.Id == id);

            if (insurance == null)
            {
                result = false;
                return result;
            }

            _context.Insurance.Remove(insurance);
            _context.SaveChanges();

            return result;
        }

        public List<Insurance> GetAll()
        {
            List<Insurance> listInsurance = _context.Insurance.ToList();

            foreach(Insurance item in listInsurance)
            {
                item.RiskType = _context.RyskType.Find(item.RiskTypeId);
                item.CoveringType = _context.CoveringType.Find(item.CoveringTypeId);
            }
    
            return listInsurance;
        }

        public Insurance GetById(int id)
        {
            Insurance insurance= _context.Insurance.FirstOrDefault(x => x.Id == id);

            insurance.RiskType = _context.RyskType.Find(id);
            insurance.CoveringType = _context.CoveringType.Find(id);

            return insurance;
        }

        public List<Insurance> GetInsuranceByClient(int id)
        {
            List<Insurance> listInsurance = _context.Insurance.Where(x => x.Id == id).ToList();

            foreach (Insurance item in listInsurance)
            {
                item.RiskType = _context.RyskType.Find(item.RiskTypeId);
                item.CoveringType = _context.CoveringType.Find(item.CoveringTypeId);
            }

            return listInsurance;
        }

        public bool InsertInsurance(Insurance insurance)
        {
            bool result;
            _context.Add(insurance);
            _context.SaveChanges();
            result = true;

            return result;
        }

        public bool UpdInsuranceById(Insurance insurance)
        {
            throw new NotImplementedException();
        }
    }
}
