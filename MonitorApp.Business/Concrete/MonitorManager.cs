using MonitorApp.Business.Abstract;
using MonitorApp.DataAccess.Abstract;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorApp.Business.Concrete
{
    public class MonitorManager : IMonitorService
    {
        public int KayitSayisi { 
            get 
            {
                return _monitorDal.GetAll().Count;
            } 
            set 
            {
            } 
        }


        private IMonitorDal _monitorDal;

        public MonitorManager(IMonitorDal monitorDal)
        {
            _monitorDal = monitorDal;
        }
        
        public void Add(Monitor monitor)
        {
            _monitorDal.Add(monitor);
        }

        public void Delete(Monitor monitor)
        {
            _monitorDal.Delete(monitor);
        }

        public List<Monitor> GetAll(Expression<Func<Monitor, bool>> filter = null)
        {
            return _monitorDal.GetAll(filter);
        }

        public void Update(Monitor monitor)
        {
            _monitorDal.Update(monitor);
        }
    }
}
