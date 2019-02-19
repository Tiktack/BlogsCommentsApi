using BusinessLayer;
using Common;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Post>> Get()
        {
            return await _postService.GetAllPosts();
        }

        // GET: api/Post/{id}
        [HttpGet("{id}")]
        public async Task<Post> Get(int id)
        {
            return await _postService.GetPost(id);
        }

        // POST: api/Post
        [HttpPost]
        public async Task Post([FromBody] Post item)
        {
            await _postService.AddPost(item);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Post item)
        {
            await _postService.UpdatePost(item, id);
        }

        // DELETE: api/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _postService.DeletePost(id);
        }
    }
}
