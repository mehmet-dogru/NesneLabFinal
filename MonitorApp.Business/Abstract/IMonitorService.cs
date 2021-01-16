using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorApp.Business.Abstract
{
    public interface IMonitorService
    {
        List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null);
        void Add(Monitor monitor);
        void Update(Monitor monitor);
        void Delete(Monitor monitor);
    }
}
