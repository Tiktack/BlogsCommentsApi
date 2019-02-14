using DataLayer.Entities;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddPost(Post post)
        {
            _unitOfWork.PostRepository.Insert(post);
            _unitOfWork.Save();
        }

        public Post GetPost(int id)
        {
            if (id < 1)
                throw new ArgumentException();
            return _unitOfWork.PostRepository.GetById(id) ?? throw new ArgumentException();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _unitOfWork.PostRepository.GetAll();
        }

        public void UpdatePost(Post post, int id)
        {
            var item = _unitOfWork.PostRepository.GetById(id);
            if (item == null)
                throw new ArgumentException($"Can not find post with id = {id}");
            post.Id = id;
            _unitOfWork.PostRepository.Update(post);
            _unitOfWork.Save();
        }

        public void DeletePost(int id)
        {
            _unitOfWork.PostRepository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
