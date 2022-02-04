namespace TwitterKristin.Models
{
    public class Post
    {
        public List <Post> Posts { get; } = new();

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

      
    }
}
