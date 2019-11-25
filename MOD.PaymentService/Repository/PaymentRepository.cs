using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repository
{
    public interface PaymentRepository
    {
        void Add(Payment item);
        List<Payment> GetAll();
        Payment GetById(int id);
        void Delete(int id);
    }
}
