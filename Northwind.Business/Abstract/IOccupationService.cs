using Racoon.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Business.Abstract
{
    public interface IOccupationService
    {
        List<Occupation> GetAll();
        void Add(Occupation occupation);
    }
}
