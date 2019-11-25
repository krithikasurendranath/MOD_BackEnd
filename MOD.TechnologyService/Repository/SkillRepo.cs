using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Context;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Repository
{
    public class SkillsRepo :SkillsRepository
    {
        private readonly SkillsContext _context;
        public SkillsRepo(SkillsContext context)
        {
            _context = context;
        }

        public void Add(Skills item)
        {
            _context.Skills.Add(item);
            _context.SaveChanges();
        }

        public List<Skills> GetAll()
        {
            return _context.Skills.ToList();
        }

        public Skills GetById(int id)
        {
            return _context.Skills.Find(id);
        }

        public void Update(Skills item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    

}
}
