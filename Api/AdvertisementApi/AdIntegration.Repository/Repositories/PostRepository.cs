using AdIntegration.Data;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;


namespace AdIntegration.Repository.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Post CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public Post DeletePostById(int id)
        {
            var foundPost = GetPostById(id);

            if (foundPost == null)
            {
                throw new InvalidOperationException();
            }

            _context.Posts.Remove(foundPost);
            return foundPost;

        }

        public Post GetPostById(int id)
        {
            var foundPost = _context.Posts.Find(id);

            if (foundPost == null)
            {
                throw new InvalidOperationException();
            }

            return foundPost;
        }

        public List<Post> GetPosts()
        {
            var posts = _context.Posts.ToList();
            return posts;
        }

        public object UpdatePostById(int id, Post post)
        {
            var foundPost = GetPostById(id);

            if (foundPost == null)
            {
                throw new InvalidOperationException();
            }

            _context.Posts.Update(post);
            var response = new
            {
                Old = foundPost,
                New = post
            };

            return response;
        }
    }
}
