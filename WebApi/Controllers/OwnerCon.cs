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

        [HttpGet("{id}")]
        public ActionResult<Owner> GetOwner(int id)
        {
            return _ownerService.FindOwnerById(id);
        }

        // POST api/<OwnerCon>
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
           return _ownerService.CreateOwner(owner);
        }

        // PUT api/<OwnerCon>/5
        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, [FromBody] Owner owner)
        {
          return _ownerService.UpdateOwner(owner);
        }

        // DELETE api/<OwnerCon>/5
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {
            return _ownerService.DeleteOwner(id);
        }
    }
}
