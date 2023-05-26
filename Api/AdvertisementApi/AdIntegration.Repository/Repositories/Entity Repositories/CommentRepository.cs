using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories;

public class CommentRepository : ICommentRepository
{
    private readonly ApplicationDbContext _context;
    public CommentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Comment> CreateComment(Comment comment)
    {
        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    public async Task<Comment> DeleteCommentById(int id)
    {
        var deleteComment = await GetCommentById(id);

        if (deleteComment != null)
        {
            _context.Comments.Remove(deleteComment);
            await _context.SaveChangesAsync();
        }

        return deleteComment;
    }

    public async Task<IEnumerable<Comment>> GetAllComments()
    {
        var comments = await _context.Comments.ToListAsync();
        return comments;
    }

    public async Task<Comment> UpdateComment(int id, Comment comment)
    {
        var foundComment = await _context.Comments.FindAsync(id);

        if (foundComment != null)
        {
            _context.Comments.Update(foundComment);
            await _context.SaveChangesAsync();
        }

        return foundComment;
    }

    public async Task<Comment> GetCommentById(int id)
    {
        var comment = await _context.Comments.FindAsync(id);
        return comment;
    }

    public async Task<IEnumerable<Comment>> GetAllCommentsFromUser(SystemUser user)
    {
        var comments = await _context.Comments
            .Where(comment => comment.UserId == user.UserId)
            .ToListAsync();

        return comments;
    }

    public async Task<IEnumerable<Comment>> GetAllCommentsFromPost(Post post)
    {
        var comments = await _context.Comments
            .Where(comment => comment.Id == post.Id)
            .ToListAsync();

        return comments;
    }
}
