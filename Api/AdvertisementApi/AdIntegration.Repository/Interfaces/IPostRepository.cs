using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IPostRepository
    {
        public Post CreatePost(Post post);
        public object UpdatePostById(int id, Post post);
        public Post DeletePostById(int id);
        public Post GetPostById(int id);
        public List<Post> GetPosts();
    }
}
