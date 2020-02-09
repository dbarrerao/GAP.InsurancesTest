using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    class InsuranceRepository : IInsuranceRepository
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
            return _context.Insurance.ToList();
        }

        public Insurance GetById(int id)
        {
            return _context.Insurance.FirstOrDefault(x => x.Id == id);
        }

        public List<Insurance> GetInsuranceByClient(int id)
        {
            return _context.Insurance.Where(x => x.Id == id).ToList();
        }

        public bool UpdInsuranceById(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
