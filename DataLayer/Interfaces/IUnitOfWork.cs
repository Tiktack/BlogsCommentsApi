using DataLayer.Interfaces.Repositories;

namespace DataLayer.Interfaces
{
    public interface IUnitOfWork
    {
        ICommentRepository CommentRepository { get; set; }
        IPostRepository PostRepository { get; set; }
        ICommentRepository Comments();
        IPostRepository Posts();
        void Save();
    }
}
