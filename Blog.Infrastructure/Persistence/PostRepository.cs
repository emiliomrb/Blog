namespace Blog.Infrastructure.Persistence
{
    using System.Collections.Generic;
    using Blog.Core.Contracts;
    using Blog.Core.Domain;
    using Blog.Infrastructure.Context;
    using Microsoft.EntityFrameworkCore;

    public class PostRepository : IPostRepository
    {
        private readonly DataContext _context;
        public PostRepository(DataContext dbContext)
        { 
            _context = dbContext;
        }

        public IEnumerable<Post> GetAllPendingPosts()
        {
            var response = _context.Posts
                .Include(p => p.Author)
                .Where(p => p.State == PostState.Pending).ToList();
            return response;
        }

        public Post? GetPostById(int postId) => _context.Posts
            .Include (p => p.Author)
            .Where(p => p.Id == postId).FirstOrDefault();

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
