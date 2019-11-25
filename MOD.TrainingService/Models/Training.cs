using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public int Tid { get; set; }
        [ForeignKey("User")]
        public int Uid { get; set; }
        [ForeignKey("Mentor")]

        public int Mid { get; set; }
        [ForeignKey("Skills")]

        public int Sid { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string timeslot { get; set; }

        public string status { get; set; }

        public string Progress { get; set; }

        public string rating { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Skills Skills { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

    }
}
