using MonitorApp.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.Entites.Concrete
{
    public class Post:IEntity
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string Details { get; set; }
    }
}
