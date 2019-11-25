using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Context;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repository
{
    public class PaymentRepo :PaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepo(PaymentContext context)
        {
            _context = context;
        }

        public void Add(Payment item)
        {
            _context.Payment.Add(item);
            _context.SaveChanges();
        }

        public List<Payment> GetAll()
        {
            return _context.Payment.ToList();
        }

        public Payment GetById(int id)
        {
            return _context.Payment.Find(id);
        }
        public void Delete(int id)
        {
            var item = _context.Payment.Find(id);
            _context.Payment.Remove(item);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
