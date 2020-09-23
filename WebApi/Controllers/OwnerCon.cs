using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SDS.Core.Application_Service;
using SDS.Core.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerCon : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerCon(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }
        // GET: api/<OwnerCon>
        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            return _ownerService.GetOwners();
        }

        // GET api/<OwnerCon>/5

        [HttpGet("{id}", Name = "Getit")]
        public Owner GetOwner(int id)
        {
            return _ownerService.FindOwnerById(id);
        }

        // POST api/<OwnerCon>
        [HttpPost]
        public void Post([FromBody] Owner owner)
        {
            _ownerService.CreateOwner(owner);
        }

        // PUT api/<OwnerCon>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Owner owner)
        {
            _ownerService.UpdateOwner(owner);
        }

        // DELETE api/<OwnerCon>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ownerService.DeleteOwner(id);
        }
    }
}
