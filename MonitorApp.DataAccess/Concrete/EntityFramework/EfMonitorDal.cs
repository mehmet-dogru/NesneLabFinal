using MonitorApp.DataAccess.Abstract;
using MonitorApp.DataAccess.Concrete.EntityFramework;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.DataAccess.Concrete
{
    public class EfMonitorDal : EfEntityRepositoryBase<Monitor,MonitorAppContext>,IMonitorDal
    {
    }
}
