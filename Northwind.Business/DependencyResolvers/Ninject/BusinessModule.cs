
using Ninject.Modules;
using Racoon.Business.Abstract;
using Racoon.Business.Concrate;
using Racoon.DataAccess.Abstract;
using Racoon.DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Business.DependencyResolvers.Ninject
{
   public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonManager>().InSingletonScope();
            Bind<IPersonDal>().To<EfPersonDal>().InSingletonScope();

            Bind<IOccupationService>().To<OccupationManager>().InSingletonScope();
            Bind<IOccupationDal>().To<EfOccupationDal>().InSingletonScope();


        }

    }
}
