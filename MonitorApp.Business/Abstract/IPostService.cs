
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorApp.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll(Expression<Func<Post, bool>> filter = null);
        void Add(Post post);
       
    }
}
