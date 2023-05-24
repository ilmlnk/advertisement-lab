using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface ICommentRepository
{
    public Comment CreateComment(Comment comment);
    public Comment UpdateComment(int id, Comment comment);
    public IEnumerable<Comment> GetAllComments();
    public Comment DeleteCommentById(int id);
    public Comment GetCommentById(int id);
}
