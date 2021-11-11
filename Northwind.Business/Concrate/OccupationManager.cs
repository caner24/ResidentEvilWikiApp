
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
   public class OccupationManager : IOccupationService
    {
        public IOccupationDal _occupationDal;
        public OccupationManager(IOccupationDal occupationDal)
        {
            _occupationDal = occupationDal;
        }

        public void Add(Occupation occupation)
        {
            ValidationTools.Validate(new OccupationValidator(), occupation);
            _occupationDal.Add(occupation);
        }

        public List<Occupation> GetAll()
        {
            return _occupationDal.GetAll();
        }

    }
}
