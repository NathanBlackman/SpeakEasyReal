using SpeakEasyReal.Models;

namespace SpeakEasyReal.Interfaces
{
    public interface IPost
    {
        public List<Post> GetAllPosts();
        public Post GetPostById(int id);
        public Post CreatePost(Post post);
        public Post UpdatePost(Post post);
        public Post DeletePost(int id);
    }
}
