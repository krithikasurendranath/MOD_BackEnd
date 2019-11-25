using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public class UserRepo : UserRepository

    {
        public readonly UserContext _context;

        public UserRepo(UserContext context)
        {
            _context = context;
        }

        public void Add(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = _context.User.Find(id);
            _context.User.Remove(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
            // throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _context.User.Find(id);
            // return _context.Employees.SingleOrDefault(i => i.Eid == id);
            // throw new NotImplementedException();
        }

        public void Update(User item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
        public List<Mentor> SearchMentor(string Mentorskills)
        {
            //return _context.Mentors.Find(MentorSkills);

            return _context.Mentor.Where(i => i.Mskills == Mentorskills).ToList();

        }


        public void Block(int id)
        {

            var item = _context.User.Find(id);
            if (item.Uactive == true)
            {
                item.Uactive = !(item.Uactive);
            }
           
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
        public void Unblock(int id)
        {

            var item = _context.User.Find(id);
            if (item.Uactive == false)
            {
                item.Uactive = !(item.Uactive);
            }

            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
