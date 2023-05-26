using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ApplicationDbContext _context;

    public PostRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Post> CreatePost(Post post)
    {
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
        return post;
    }

    public async Task<Post> DeletePostById(int id)
    {
        var foundPost = await GetPostById(id);

        if (foundPost != null)
        {
            _context.Posts.Remove(foundPost);
            await _context.SaveChangesAsync();
        }
        return foundPost;

    }

    public async Task<Post> GetPostById(int id)
    {
        var foundPost = await _context.Posts.FindAsync(id);
        return foundPost;
    }

    public async Task<IEnumerable<Post>> GetPosts()
    {
        var posts = await _context.Posts.ToListAsync();
        return posts;
    }

    public async Task<object> UpdatePostById(int id, Post post)
    {
        var foundPost = await GetPostById(id);

        if (foundPost != null)
        {
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
        }

        var response = new
        {
            Old = foundPost,
            New = post
        };

        return response;
    }
}
