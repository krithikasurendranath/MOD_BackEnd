using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public interface UserRepository
    {
        
            void Add(User item);
            List<User> GetAll();
            User GetById(int id);
            void Update(User item);
            void Delete(int id);
            void Block(int id);
        void Unblock(int id);
        List<Mentor> SearchMentor(string MentorSkills);

        

    
    }
}
