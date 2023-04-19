namespace SpeakEasyReal.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public int PostLength { get; set; }
    }
}
