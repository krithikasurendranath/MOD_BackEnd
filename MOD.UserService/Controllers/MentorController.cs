using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;

using MOD.UserService.Repository;

namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly MentorRepository _repository;
        public MentorController(MentorRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("GetMentor")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }






        //[HttpGet("{id}", Name = "Get")]
        [Route("GetMentorById/{id}")]
        public Mentor Get(int id)
        {
            return _repository.GetById(id);
        }


        [HttpPost]
        [Route("AddMentor")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }


        [HttpPut("{id}")]
        [Route("UpdateMentor")]

        public void Put(Mentor item)
        {
            _repository.Update(item);
        }


        [HttpDelete("{id}")]
        [Route("DeleteMentor/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        [HttpPut("{id}")]
        [Route("Block/{id}")]
        public void put(int id)
        {
            _repository.Block(id);
        }
        [HttpPut("{id}")]
        [Route("Unblock/{id}")]
        public void unblock(int id)
        {
            _repository.Unblock(id);
        }
    }
}
