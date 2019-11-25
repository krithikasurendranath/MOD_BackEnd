using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Models
{
    public class Skills
    {
        [Key]
        public int Sid { get; set; }
        
        public string Sname { get; set; }

        public string STOC { get; set; }

        public double Sfee { get; set; }

        public int Sduration { get; set; }
        

    }
}
