using Microsoft.Extensions.Configuration;

namespace HttpFirst
{
    public class Starter
    {
        private IApplication _application;

        public Starter(IApplication application)
        {
            _application = application;
        }

        public async Task Run()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();
            var serverURL = config.GetConnectionString("DefaultConnection");
            await _application.Run(serverURL);
        }
    }
}
