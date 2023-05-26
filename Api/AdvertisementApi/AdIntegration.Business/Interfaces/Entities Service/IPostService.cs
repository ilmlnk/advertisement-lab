using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces;

public interface IPostService
{
    public Task<Post> CreatePost(Post post);
    public Task<object> UpdatePostById(int id, Post post);
    public Task<Post> GetPostById(int id);
    public Task<IEnumerable<Post>> GetPosts();
    public Task<Post> DeletePostById(int id);
}
