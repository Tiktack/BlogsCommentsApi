using BusinessLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Common;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

// ReSharper disable once IdentifierTypo
namespace Travix.Controllers
{
    [ModelValidation]
    [ApiExceptionFilter]
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly ILogger<PostController> _logger;

        public PostController(IPostService postService, ILogger<PostController> logger)
        {
            _postService = postService;
            _logger = logger;
        }

        // GET: api/Post
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postService.GetAllPosts();
        }

        // GET: api/Post/{id}
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _postService.GetPost(id);
        }

        // POST: api/Post
        [HttpPost]
        public void Post([FromBody] Post item)
        {
            _postService.AddPost(item);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Post item)
        {
            _postService.UpdatePost(item, id);
        }

        // DELETE: api/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _postService.DeletePost(id);
        }
    }
}
