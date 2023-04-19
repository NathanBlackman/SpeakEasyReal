using Microsoft.AspNetCore.Mvc;
using SpeakEasyReal.Models;
using SpeakEasyReal.Interfaces;

namespace SpeakEasyReal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPost _postRepo;
        public PostController(IPost postRepository)
        {
            _postRepo = postRepository;
        }

        // Get
        [HttpGet]
        public List<Post> GetAllPosts()
        {
            return _postRepo.GetAllPosts();
        }

        // Get by Id
        [HttpGet("{id}")]
        public Post GetPostById(int id)
        {
            return _postRepo.GetPostById(id);
        }
        
        // Post
        [HttpPost("postPost")]
        public IActionResult CreatePost(Post post)
        {
            var newPost = _postRepo.CreatePost(post);
            return Ok(newPost);
        }

        // Update
        [HttpPut("updatePost/{id}")]
        public IActionResult UpdatePost(Post post)
        {
            _postRepo.UpdatePost(post);
            return NoContent();
        }

        // Delete
        [HttpDelete("deletePost/{id}")]
        public void DeletePost(int id)
        {
            _postRepo.DeletePost(id);
        }

    }
}
