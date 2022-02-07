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
using HttpFirst.Users;
using HttpFirst.Resources;

namespace HttpFirst
{
    public class Application : IApplication
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

        public async Task Run(string serverURL)
        {
            var taskList = new List<Task>();
            taskList.Add(_userService.Query1(serverURL));
            taskList.Add(_userService.Query2(serverURL));
            taskList.Add(_userService.Query3(serverURL));
            taskList.Add(_resourceService.Query4(serverURL));
            taskList.Add(_resourceService.Query5(serverURL));
            taskList.Add(_resourceService.Query6(serverURL));
            await Task.WhenAll(taskList);
        }
    }
}
