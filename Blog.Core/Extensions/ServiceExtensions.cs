namespace Blog.Core.Extensions
{
    using System.Reflection;
    using Blog.Core.Domain;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Post).Assembly));
            
        }
    }


}
