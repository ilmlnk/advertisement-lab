using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface ICommentRepository
{
    public Task<Comment> CreateComment(Comment comment);
    public Task<Comment> UpdateComment(int id, Comment comment);
    public Task<IEnumerable<Comment>> GetAllComments();
    public Task<Comment> DeleteCommentById(int id);
    public Task<Comment> GetCommentById(int id);
    public Task<IEnumerable<Comment>> GetAllCommentsFromUser(SystemUser user);
    public Task<IEnumerable<Comment>> GetAllCommentsFromPost(Post post);
}
