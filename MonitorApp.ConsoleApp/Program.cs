using MonitorApp.Business.Abstract;
using MonitorApp.Business.Concrete;
using MonitorApp.Business.DependencyResolvers.Ninject;
using MonitorApp.DataAccess.Concrete;
using MonitorApp.DataAccess.Concrete.ADONET;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //MonitorManager monitorManager = new MonitorManager(new AdoMonitorDal());
            //var monitor = monitorManager.GetAll();
            //foreach (var item in monitor)
            //{
            //    Console.WriteLine(item);
            //}

            var monitorService = InstanceFactory.Get<IMonitorService>();

            //var list = monitorService.GetAll();
            //foreach (var m in list)
            //{
            //    Console.WriteLine(m);
            //}

            //monitorService.Update(new Monitor { Id = 1, Model = "Monster Gaming", Fiyat = 2000, Boyut = 22 });

            //monitorService.Delete(new Monitor
            //{
            //    Id = 2
            //});

            //monitorService.Update(new Monitor
            //{
            //    Id = 7,
            //    Fiyat = Convert.ToDecimal(815)
            //});

            var postService = InstanceFactory.Get<IPostService>();
            postService.Add(new Post
            {
                PostId = 1,
                PostTitle = "Deneme",
                Details = "deneme details"
            });

            var posts = postService.GetAll();
            foreach (var p in posts)
            {
                Console.WriteLine(p);
            }

            //var Sirala = from item in monitorService.GetAll()
            //             orderby item.Fiyat
            //             select item;
            //             //where item.Fiyat       


            //foreach (var m in Sirala)
            //{
            //    Console.WriteLine(m);
            //}
            //Console.WriteLine("*****************************");

            //MonitorManager monitorManager = new MonitorManager(new EfMonitorDal());
            //Console.WriteLine("Kayıt Sayısı: " + monitorManager.KayitSayisi);


            Console.ReadKey();
        }
    }
}
