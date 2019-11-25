using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.PaymentService.Models;
using MOD.PaymentService.Repository;

namespace MOD.PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
            private readonly PaymentRepository _repository;
              public PaymentController (PaymentRepository repository)
            {
                _repository = repository;
            }
            // GET: api/Payment
            [HttpGet]
            [Route("GetPayment")]
            public List<Payment> Get()
            {
                return _repository.GetAll();
            }

            // GET: api/Payment/5
            // [HttpGet("{id}", Name = "Get")]
            [Route("GetPaymentById/{id}")]
            public Payment Get(int id)
            {
                return _repository.GetById(id);
            }

            // POST: api/Payment
            [HttpPost]
            [Route("AddPayment")]
            public IActionResult Post([FromBody] Payment item)
            {
                _repository.Add(item);
                return Ok("Record Added");
            }

            // PUT: api/Payment/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

       
        }
    }