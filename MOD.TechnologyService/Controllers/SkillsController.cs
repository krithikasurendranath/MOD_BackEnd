using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repository;

namespace MOD.TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly SkillsRepository _repository;
        public SkillsController(SkillsRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Skills
        [HttpGet]
        [Route("GetSkills")]
        public List<Skills> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Skills/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetSkillsById/{id}")]
        public Skills Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Skills
        [HttpPost]
        [Route("AddSkills/{id}")]
        public IActionResult Post([FromBody] Skills item)
        {
            _repository.Add(item);
            return Ok();
        }

        // PUT: api/Skills/5
        [HttpPut("{id}")]
        [Route("UpdateSkills/{id}")]
        public IActionResult Put([FromBody] Skills item)
        {
            _repository.Update(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
