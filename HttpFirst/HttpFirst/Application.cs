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
    public class Application
    {
        private IHttpService _httpService;
        private IUserService _userService;
        private IResourceService _resourceService;
        private IAuthService _authService;

        public Application(IHttpService httpService, IUserService userService, IResourceService resourceService, IAuthService authService)
        {
            _httpService = httpService;
            _userService = userService;
            _resourceService = resourceService;
            _authService = authService;
        }

        public async Task Run(IConfigurationRoot config)
        {
            var serverURL = config.GetConnectionString("DefaultConnection");

        }
    }
}
