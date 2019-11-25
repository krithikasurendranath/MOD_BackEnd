using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Models
{
    public class User
    {
        [Key]
        public int Uid { get; set; }

        public string Uname { get; set; }

        public string Umail { get; set; }

        public int Unumber { get; set; }
        public string Upassword { get; set; }
        public bool Uactive { get; set; }
    }
}
