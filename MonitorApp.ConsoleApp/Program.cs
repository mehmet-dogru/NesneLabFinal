using MonitorApp.Business.Abstract;
using MonitorApp.Business.Concrete;
using MonitorApp.Business.DependencyResolvers.Ninject;
using MonitorApp.DataAccess.Concrete;
using MonitorApp.DataAccess.Concrete.ADONET;
using System;

namespace MonitorApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MonitorManager monitorManager = new MonitorManager(new EfMonitorDal());
            //var monitor = monitorManager.GetAll();
            //foreach (var item in monitor)
            //{
            //    Console.WriteLine(item);
            //}

            MonitorManager monitorManager = new MonitorManager(new AdoMonitorDal());
            var monitor = monitorManager.GetAll();
            foreach (var item in monitor)
            {
                Console.WriteLine(item);
            }


            //var monitorService = InstanceFactory.Get<IMonitorService>();
            //var list = monitorService.GetAll();
            //foreach (var m in list)
            //{
            //    Console.WriteLine(m);
            //}

            Console.ReadKey();
        }
    }
}
