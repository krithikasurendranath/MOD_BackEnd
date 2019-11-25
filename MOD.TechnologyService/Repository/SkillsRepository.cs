using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Repository
{
     public interface SkillsRepository
    {
        void Add(Skills item);
        void Update(Skills item);
        List<Skills> GetAll();
        Skills GetById(int id);

    }
}
