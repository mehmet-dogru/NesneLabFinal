using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorApp.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
       
    }
}
