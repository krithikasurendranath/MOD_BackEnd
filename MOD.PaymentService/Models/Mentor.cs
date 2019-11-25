using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    public class Mentor
    {
        [Key]
        public int Mid { get; set; }
        public string Mname { get; set; }
        
        public string Mmail { get; set; }
     
        public int Mnumber { get; set; }
        public string Mpassword { get; set; }
        public string Mskills { get; set; }
        public int Mexperience { get; set; }
        public string Mtimeslot { get; set; }
        public bool Mavailability { get; set; }
        public bool Mactive { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
