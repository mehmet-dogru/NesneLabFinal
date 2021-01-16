using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.DataAccess.Abstract
{
    public interface IMonitorDal : IEntityRepository<Monitor>
    {
    }
}
