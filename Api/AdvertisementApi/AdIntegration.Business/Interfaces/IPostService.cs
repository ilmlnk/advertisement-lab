using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface IPostService
    {
        public Post CreatePost(Post post);
        public object UpdatePostById(int id, Post post);
        public Post GetPostById(int id);
        public IEnumerable<Post> GetPosts();
        public Post DeletePostById(int id);
    }
}
