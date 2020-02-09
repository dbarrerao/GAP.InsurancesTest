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
        
        [HttpGet("{id}", Name = "GetClient")]
        public ActionResult<Client> GetClientById(string document)
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

            return new CreatedAtRouteResult("GetClient", new { doccument = client.Document }, client);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Client client)
        {
            if(id != client.Id)
            {
                return BadRequest();
            }

            clientBusiness.UpdClientById(id);

            return Ok();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult<Client> Delete(int id)
        {
            var client = clientBusiness.GetById(id);

            if (client == null)
            {
                return NotFound();
            }

            clientBusiness.DelClientById(id);

            return Ok();
        }
    }
}
