using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repository;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly TrainingRepository _repository;
        public TrainingController(TrainingRepository repository)
        {
            _repository = repository;
        }


        
        [Route("GetTraining")]
        public IEnumerable<Training> Get()
        {
            return _repository.GetAll();
        }

        //[HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingById/{id}")]
        public Training Get(int id)
        {
            return _repository.GetById(id);
        }


        [HttpPost]
        [Route("AddTraining/{id}")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.Add(item);
            return Ok();
        }


        [HttpPut("{id}")]
        [Route("UpdateTraining/{id}")]

        public IActionResult Put([FromBody]Training item)
        {
            _repository.Update(item);
            return Ok();
        }
        [HttpGet("{id}", Name = "GetbyUser")]
        [Route("GetTrainingByUser/{id}")]
        public List<Training> GetbyUser(int id)
        {
            return _repository.GetTrainingsByUserId(id);


        }
        [HttpGet("{id}", Name = "GetbyMentor")]
        [Route("GetTrainingByMentor/{id}")]
        public List<Training> GetbyMentor(int id)
        {
            return _repository.GetTrainingsByMentorId(id);

        }


        [HttpDelete("{id}")]
        [Route("DeleteTraining/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
        public void Block(int id)
        {
            _repository.Block(id);
        }

    }
}
