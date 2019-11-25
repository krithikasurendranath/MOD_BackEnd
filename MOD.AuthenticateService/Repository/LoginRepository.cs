using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.AuthenticateService.Models;

namespace MOD.AuthenticateService.Repository
{
    public interface LoginRepository
    {
        User Userlogin(string Email, string Upassword);
        Mentor Mentorlogin(string Email, string Mpassword);
    }
}
