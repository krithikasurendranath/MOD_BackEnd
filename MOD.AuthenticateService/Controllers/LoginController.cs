using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.AuthenticateService.Models;
using MOD.AuthenticateService.Repository;

namespace MOD.AuthenticateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginRepository _repository;
        public LoginController(LoginRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Validate/{mail}/{pwd}")]
        public Atoken Get(string mail, string pwd)
        {
            if (_repository.Userlogin(mail, pwd) != null)
            {
                User response = _repository.Userlogin(mail, pwd);
                return new Atoken() { message = "User", token = response.Uid.ToString() };
            }
            else if (_repository.Mentorlogin(mail, pwd)!= null)
            {
                Mentor response = _repository.Mentorlogin(mail, pwd);
                return new Atoken() { message = "Mentor", token = response.Mid.ToString() };
            }
            else if (mail == "admin123@gmail.com" && pwd == "admin123")
            {
                return new Atoken() { message = "Admin", token = GetToken() };
            }
            else
            {
                return new Atoken() { message = "Invalid User", token = "" };
            }
        }
        public string GetToken()
        {
            return "";
        }

    }

}