using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAP.Business.Interfaces;
using GAP.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GAP.InsurancesTest.Controllers
{
    [Route("api/[controller]")]
    public class InsuranceController : Controller
    {
        private IInsuranceBusiness _insuranceBusiness;

        public InsuranceController(IInsuranceBusiness insuranceBusiness)
        {
            _insuranceBusiness = insuranceBusiness;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<Insurance>> GetAll()
        {
            return _insuranceBusiness.GetAll();            
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Insurance> GetById(int id)
        {
            Insurance insurance = _insuranceBusiness.GetById(id);

            if (insurance == null)
            {
                return NotFound();
            }

            return insurance;
        }

        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody]Insurance insurance)
        {
            return _insuranceBusiness.InsertInsurance(insurance);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _insuranceBusiness.DelInsuranceById(id);
        }
    }
}
