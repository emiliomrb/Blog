namespace Blog.Infrastructure.Persistence
{
    using System;
    using System.Collections.Generic;
    using Blog.Core.Contracts;
    using Blog.Core.Domain;
    using Blog.Infrastructure.Context;

    public class PostRepository : IPostRepository
    {
        private readonly DataContext _context;
        public PostRepository(DataContext dbContext)
        { 
            _context = dbContext;
        }

        public IEnumerable<Post> GetAllPendingPosts()
        {
            return _context.Posts.Where(p => p.State == PostState.Pending);
        }
    }
}
