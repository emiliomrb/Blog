namespace Blog.Infrastructure.Context
{
    using Blog.Core.Domain;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {            
        }

        public DbSet<Post> Posts { get; set; }
    }
}
