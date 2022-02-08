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
            var taskList = new List<Task>
            {
                _userService.Query1(serverURL),
                _userService.Query2(serverURL),
                _userService.Query3(serverURL),
                _resourceService.Query4(serverURL),
                _resourceService.Query5(serverURL),
                _resourceService.Query6(serverURL)
            };
            foreach (var item in taskList)
            {
                item.Start();
            }

            await Task.WhenAll(taskList);
        }
    }
}
