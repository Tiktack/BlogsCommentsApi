using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces.Repositories;

namespace DataLayer.Repositories
{
    //public class CommentRepository : ICommentRepository
    //{
    //    private readonly BaseContext _context;

    //    public CommentRepository(BaseContext context)
    //    {
    //        _context = context;
    //    }

    //    public async Task Insert(Comment item)
    //    {
    //         await _context.Comments.AddAsync(item);
    //    }

    //    public Task Delete(int id)
    //    {
    //        var comment = _context.Comments.Find(id);
    //        _context.Comments.Remove(comment);
    //    }

    //    public Task Update(Comment item)
    //    {
    //        _context.Entry(item).State = EntityState.Modified;
    //    }

    //    public Task<Post> GetById(int id)
    //    {
    //        return _context.Comments.Find(id);
    //    }

    //    public Task<List<Post>> GetAll()
    //    {
    //        return _context.Comments.ToList();
    //    }
    //}
}
