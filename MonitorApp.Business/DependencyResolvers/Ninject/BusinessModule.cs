using MonitorApp.Business.Abstract;
using MonitorApp.Business.Concrete;
using MonitorApp.DataAccess.Abstract;
using MonitorApp.DataAccess.Concrete;
using MonitorApp.DataAccess.Concrete.ADONET;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMonitorService>().To<MonitorManager>().InSingletonScope();
            Bind<IMonitorDal>().To<EfMonitorDal>().InSingletonScope();
        }
    }
}
