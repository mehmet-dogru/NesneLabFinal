using MonitorApp.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.Entites.Concrete
{
    public class Monitor : IEntity
    {
        public Monitor(int id, string model, decimal fiyat, decimal boyut)
        {
            Id = id;
            Model = model;
            Fiyat = fiyat;
            Boyut = boyut;
        }
        public Monitor()
        {

        }
       
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Boyut { get; set; }

        public override string ToString()
        {
            return $"ID:{Id,-5} Model:{Model,-15} Fiyat:{Fiyat+" TL",-15} Boyut:{Boyut+" inç"}";
        }
    }
}
