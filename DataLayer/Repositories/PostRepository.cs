using DataLayer.Entities;
using DataLayer.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BaseContext _context;

        public PostRepository(BaseContext context)
        {
            _context = context;
        }
        public void Insert(Post item)
        {
            _context.Posts.Add(item);
        }

        public void Delete(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null)
                throw new ArgumentException($"Can not find post with id {id}");
            _context.Posts.Remove(post);
        }

        public void Update(Post item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public Post GetById(int id)
        {
            return _context.Posts.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts;
        }
    }
}
