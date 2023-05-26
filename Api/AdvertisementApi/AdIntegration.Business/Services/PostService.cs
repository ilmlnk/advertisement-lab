using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;

namespace AdIntegration.Business.Services;

public class PostService : IPostService
{
    private readonly PostRepository _postRepository;
    public PostService(PostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<Post> CreatePost(Post post)
    {
        return await _postRepository.CreatePost(post);
    }

    public async Task<Post> DeletePostById(int id)
    {
        return await _postRepository.DeletePostById(id);
    }

    public async Task<Post> GetPostById(int id)
    {
        return await _postRepository.GetPostById(id);
    }

    public async Task<IEnumerable<Post>> GetPosts()
    {
        return await _postRepository.GetPosts();
    }

    public async Task<object> UpdatePostById(int id, Post post)
    {
        return await _postRepository.UpdatePostById(id, post);
    }
}
