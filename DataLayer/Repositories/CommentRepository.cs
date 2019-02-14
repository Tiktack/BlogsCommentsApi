using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Interfaces.Repositories;

namespace DataLayer.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BaseContext _context;

        public CommentRepository(BaseContext context)
        {
            _context = context;
        }

        public void Insert(Comment item)
        {
            _context.Comments.Add(item);
        }

        public void Delete(int id)
        {
            var comment = _context.Comments.Find(id);
            _context.Comments.Remove(comment);
        }

        public void Update(Comment item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }
    }
}
