using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json;

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
            await _application.Run(config);
        }
    }
}
