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
    public class ClientController : Controller
    {
        private IClientBusiness clientBusiness;


        public ClientController(IClientBusiness _clientBusiness)
        {
            clientBusiness = _clientBusiness;
        }        
        
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            return clientBusiness.GetAll();
        }
        
        [HttpGet("{document}")]
        public ActionResult<Client> GetClientByDocument(int document)
        {
            var client = clientBusiness.GetByDocument(document);

            if(client == null)
            {
                return NotFound();
            }

            return client;
        }
       
        [HttpPost]
        public ActionResult Post([FromBody] Client client)
        {
            clientBusiness.InsertClient(client);

            return new CreatedAtRouteResult("GetClient", new { document = client.Document }, client);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Client client)
        {
            
            if(id != client.Id)
            {
                return BadRequest();
            }

            bool result = clientBusiness.UpdClientById(client);

            return result;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {  
            bool result = clientBusiness.DelClientById(id);

            return result;
        }
    }
}
