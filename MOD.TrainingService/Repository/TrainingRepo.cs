using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repository
{
    public class TrainingRepo : TrainingRepository
    {
        public readonly TrainingContext _context;

        public TrainingRepo(TrainingContext context)
        {
            _context = context;
        }

        public void Add(Training item)
        {
            _context.Training.Add(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = _context.Training.Find(id);
            _context.Training.Remove(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAll()
        {
            return _context.Training;
            // throw new NotImplementedException();
        }

        public Training GetById(int id)
        {
            return _context.Training.Find(id);
            // return _context.Employees.SingleOrDefault(i => i.Eid == id);
            // throw new NotImplementedException();
        }

        public void Update(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Block(int id)
        {
            //throw new NotImplementedException();
        }
        public List<Training> GetTrainingsByUserId(int id)
        {
            return _context.Training.Where(i => i.Uid == id).ToList();
        }

        public List<Training> GetTrainingsByMentorId(int id)
        {
            return _context.Training.Where(i => i.Mid == id).ToList();
            //throw new NotImplementedException();
        }
    }
}
