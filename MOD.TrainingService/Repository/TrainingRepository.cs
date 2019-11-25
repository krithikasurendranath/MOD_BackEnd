using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repository
{
    public interface TrainingRepository
    {
        void Add(Training item);
        IEnumerable<Training> GetAll();
        Training GetById(int id);
        void Update(Training item);
        void Delete(int id);
        void Block(int id);

        List<Training> GetTrainingsByMentorId(int id);
        List<Training> GetTrainingsByUserId(int id);

    }
}
