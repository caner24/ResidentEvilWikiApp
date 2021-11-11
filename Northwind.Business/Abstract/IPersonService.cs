using Racoon.DataAccess.Abstract;
using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();

        List<Person> GetPersonById(int categoryId);
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
    }
}
