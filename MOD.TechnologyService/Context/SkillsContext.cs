using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Context
{
    public class SkillsContext :DbContext

    {
        public SkillsContext(DbContextOptions<SkillsContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
