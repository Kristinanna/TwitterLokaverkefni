using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TwitterKristin.Models;

namespace TwitterKristin.Controller
{
 
        [Route("api/twitter")]
        [Controller]

        public class TwitterController : ControllerBase
        {
        

        [HttpGet] 
        public List <Post> Getallposts()
        {
            return new List<Post>() {

           new Post() { PostId = 1, Title = "hello", Content = "brother" },
           new Post() { PostId = 2, Title = "hello", Content = "mother" },
           new Post() { PostId = 3, Title = "hello", Content = "sister" },
           new Post() { PostId = 4, Title = "hello", Content = "father" },
           
            };
        }
    }
}
