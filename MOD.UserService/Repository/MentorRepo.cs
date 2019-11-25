using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public class MentorRepo : MentorRepository
    {
        public readonly UserContext _context;

        public MentorRepo(UserContext context)
        {
            _context = context;
        }

        public void Add(Mentor item)
        {
            _context.Mentor.Add(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public List<Mentor> GetAll()
        {
            return _context.Mentor.ToList();
            // throw new NotImplementedException();
        }

        public Mentor GetById(int id)
        {
            return _context.Mentor.Find(id);
            // return _context.Employees.SingleOrDefault(i => i.Eid == id);
            // throw new NotImplementedException();
        }

        public void Update(Mentor item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Block(int id)
        {
            var item = _context.Mentor.Find(id);
            if (item.Mactive == true)
            { 
                item.Mactive = !(item.Mactive);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
        public void Unblock(int id)
        {
            var item = _context.Mentor.Find(id);
            if (item.Mactive == false)
            {
                item.Mactive = !(item.Mactive);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
