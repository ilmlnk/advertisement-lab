using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces
{
    public interface ICommentRepository
    {
        public Comment CreateComment(Comment comment);
        public Comment UpdateComment(Comment comment);
        public IEnumerable<Comment> GetAllComments();
        public Comment DeleteCommentById(int id);
    }
}
