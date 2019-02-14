using System.Collections.Generic;
using DataLayer.Entities;

namespace BusinessLayer
{
    public interface IPostService
    {
        void AddPost(Post post);
        Post GetPost(int id);
        IEnumerable<Post> GetAllPosts();
        void UpdatePost(Post post, int id);
        void DeletePost(int id);
    }
}