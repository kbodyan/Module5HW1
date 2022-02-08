using HttpFirst.Responses;

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
            await Task.WhenAll(
                _userService.Query1(serverURL),
                _userService.Query2(serverURL),
                _userService.Query3(serverURL),
                _resourceService.Query4(serverURL),
                _resourceService.Query5(serverURL),
                _resourceService.Query6(serverURL),
                _userService.Query7(serverURL),
                _userService.Query8(serverURL),
                _userService.Query9(serverURL),
                _userService.Query10(serverURL),
                _authService.Query11(serverURL),
                _authService.Query12(serverURL),
                _authService.Query13(serverURL),
                _authService.Query14(serverURL),
                _userService.Query15(serverURL));
        }
    }
}
