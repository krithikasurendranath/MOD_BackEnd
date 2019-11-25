using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Models
{
    public class Payment
    {
        [Key]
        public int Pid { get; set; }
        
        [ForeignKey("User")]

        public int Uid { get; set; }
        [ForeignKey("Mentor")]
        public int Mid { get; set; }
        public int amount { get; set; }
       
        

        public int Mentor_Amount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
       
    }
}
