
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Racoon.Business.Abstract;
using Racoon.DataAccess.Abstract;
using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Business.Concrate
{
    public class PersonManager : IPersonService
    {
        public IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void Add(Person person)
        {
                ValidationTools.Validate(new PersonValidator(), person);
                _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public List<Person> GetPersonById(int personId)
        {
            return _personDal.GetAll(p => p.PersonId == personId);
        }

        public void Update(Person person)
        {
            ValidationTools.Validate(new PersonValidator(), person);
            _personDal.Update(person);
        }
    }
}
