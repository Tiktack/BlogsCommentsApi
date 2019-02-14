using DataLayer.Interfaces;
using DataLayer.Interfaces.Repositories;
using System;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BaseContext _context;
        public ICommentRepository CommentRepository { get; set; }
        public IPostRepository PostRepository { get; set; }
        private bool _disposed;

        public UnitOfWork(ICommentRepository commentRepository, IPostRepository postRepository, BaseContext context)
        {
            CommentRepository = commentRepository;
            PostRepository = postRepository;
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public ICommentRepository Comments() => CommentRepository;
        public IPostRepository Posts() => PostRepository;

        public virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
