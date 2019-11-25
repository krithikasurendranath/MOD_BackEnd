using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
        public interface MentorRepository
    {
        void Add(Mentor item);
        List<Mentor> GetAll();
        Mentor GetById(int id);
        void Update(Mentor item);
        void Delete(int id);
        void Block(int id);
        void Unblock(int id);
    }
}
