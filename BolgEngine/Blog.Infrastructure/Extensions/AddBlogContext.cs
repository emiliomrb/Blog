namespace Blog.Infrastructure.Extensions
{
    using Blog.Core.Contracts;
    using Blog.Infrastructure.Context;
    using Blog.Infrastructure.Persistence;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceContainerExtensions
    {
        public static void AddPersistence (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));

            services.AddScoped<IPostRepository, PostRepository>();
        }
    }
}
