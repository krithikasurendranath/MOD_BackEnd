using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Context
{
    public class TrainingContext :DbContext

    {
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseSqlServer(@"Server = DESKTOP-NCNTOC7\KRITHIKA;Database=MODdb;Trusted_Connection=True");
        //}
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Payment> Payment { get; set; }

    }
}
