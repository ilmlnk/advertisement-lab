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

    public Post CreatePost(Post post)
    {
        return _postRepository.CreatePost(post);
    }

    public Post DeletePostById(int id)
    {
        return _postRepository.DeletePostById(id);
    }

    public Post GetPostById(int id)
    {
        return _postRepository.GetPostById(id);
    }

    public IEnumerable<Post> GetPosts()
    {
        return _postRepository.GetPosts();
    }

    public object UpdatePostById(int id, Post post)
    {
        return _postRepository.UpdatePostById(id, post);
    }
}
