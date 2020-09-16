using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SDS.Core.Application_Service;
using SDS.Core.Domain_Service;
using SDS.Core.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvatarCon : ControllerBase
    {
        private readonly IAvatarService _avatarService;

        public AvatarCon(IAvatarService avatarService)
        {
            _avatarService = avatarService;
        }
        // GET: api/<AvatarCon>
        [HttpGet]
        public IEnumerable<Avatar> Get()
        {
            return _avatarService.GetAvatars();
        }

        // GET api/<AvatarCon>/5
        [HttpGet("{id}", Name = "Get")]
        public Avatar Get(int id)
        {
            return _avatarService.ReadById(id);
        }

        // POST api/<AvatarCon>
        [HttpPost]
        public void Post([FromBody] Avatar avatar)
        {
            _avatarService.Create(avatar);
        }

        // PUT api/<AvatarCon>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Avatar avatar)
        {
            _avatarService.Update(avatar);

        }

        // DELETE api/<AvatarCon>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _avatarService.Delete(id);
        }
    }
}
