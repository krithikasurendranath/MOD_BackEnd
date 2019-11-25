using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;
using MOD.UserService.Repository;

namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {



        private readonly UserRepository _repository;
        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        
        [HttpGet]
        [Route("GetUser")]
        public List<User> Get()
        {
            return _repository.GetAll();
        }





       
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetUserById/{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }

        
        [HttpPost]
        [Route("AddUser")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

       
        [HttpPut("{id}")]
        [Route("UpdateUser")]

        public void Put(User item)
        {
            _repository.Update(item);
        }

        
        [HttpDelete("{id}")]
        [Route("DeleteUser/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        [Route("GetMskills/{id}")]
        public List<Mentor> Get(string id)
        {
            return _repository.SearchMentor(id);
        }

        [HttpPut("{id}")]
        [Route("Block/{id}")]
        public void put(int Id)
        {
            _repository.Block(Id);
        }
        [HttpPut("{id}")]
        [Route("Unblock/{id}")]
        public void unblock(int Id)
        {
            _repository.Unblock(Id);
        }
    }
}