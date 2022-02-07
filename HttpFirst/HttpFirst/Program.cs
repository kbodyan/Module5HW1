using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

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
                .AddTransient<Starter>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Starter>();
            await start.Run();
        }
    }
}
