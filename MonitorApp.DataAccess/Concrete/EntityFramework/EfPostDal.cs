using MonitorApp.DataAccess.Abstract;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.DataAccess.Concrete.EntityFramework
{
    public class EfPostDal:EfEntityRepositoryBase<Post,MonitorAppContext>,IPostDal
    {
    }
}
