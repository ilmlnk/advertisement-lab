using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface IPostRepository
{
    public Task<Post> CreatePost(Post post);
    public Task<object> UpdatePostById(int id, Post post);
    public Task<Post> DeletePostById(int id);
    public Task<Post> GetPostById(int id);
    public Task<IEnumerable<Post>> GetPosts();
}
