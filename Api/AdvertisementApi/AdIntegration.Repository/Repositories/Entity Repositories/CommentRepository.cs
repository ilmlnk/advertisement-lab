using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories;

public class CommentRepository : ICommentRepository
{
    private readonly ApplicationDbContext _context;
    public CommentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Comment CreateComment(Comment comment)
    {
        _context.Comments.Add(comment);
        _context.SaveChanges();
        return comment;
    }

    public Comment DeleteCommentById(int id)
    {
        var deleteComment = GetCommentById(id);
        _context.Comments.Remove(deleteComment);
        _context.SaveChanges();

        return deleteComment;
    }

    public IEnumerable<Comment> GetAllComments()
    {
        var comments = _context.Comments.ToList();
        return comments;
    }

    public Comment UpdateComment(int id, Comment comment)
    {
        var foundComment = _context.Comments.Find(id);
        if (foundComment != null)
        {
            _context.Comments.Update(foundComment);
            _context.SaveChanges();
            return foundComment;
        }
        return null;
    }

    public Comment GetCommentById(int id)
    {
        var comment = _context.Comments.Find(id);

        if (comment != null)
        {
            return comment;
        }
        return null;
    }
}
