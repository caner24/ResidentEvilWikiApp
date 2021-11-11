using Racoon.DataAccess.Abstract;
using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.DataAccess.Concrate.EntityFramework
{
    public class EfOccupationDal:EfEntityRepositoryBase<Occupation,RacoonContext>,IOccupationDal
    {
    }
}
