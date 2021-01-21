using MonitorApp.Business.Abstract;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MonitorApp.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostService _postService;

        public PostManager(IPostService postService)
        {
            _postService = postService;
        }

        public void Add(Post post)
        {
            _postService.Add(post);
        }

        public void Delete(Post post)
        {
            
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            return null;
        }

        public void Update(Post post)
        {
        }
    }
}
