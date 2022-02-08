using Microsoft.Extensions.DependencyInjection;

namespace HttpFirst
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IHttpService, HttpService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IResourceService, ResourceService>()
                .AddTransient<IAuthService, AuthService>()
                .AddTransient<IApplication, Application>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Starter>();
            if (start != null)
            {
                await start.Run();
            }
        }
    }
}
