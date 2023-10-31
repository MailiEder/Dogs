using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Models
{
    public interface IDogRepository
    {
        void Add(DogModel dogModel);
        void Edit(DogModel dogModel);
        void Delete(int id);
        IEnumerable<DogModel> GetAll();
        IEnumerable<DogModel> GetByValue(string value);
    }
}
