using HttpFirst.Responses;
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
            await Task.WhenAll(
                Task<Response1?>.Run(() => _userService.Query1(serverURL)),
                Task<User?>.Run(() => _userService.Query2(serverURL)),
                Task<User?>.Run(() => _userService.Query3(serverURL)),
                Task<Response4?>.Run(() => _resourceService.Query4(serverURL)),
                Task<Resource?>.Run(() => _resourceService.Query5(serverURL)),
                Task<Resource?>.Run(() => _resourceService.Query6(serverURL)),
                Task<Response7?>.Run(() => _userService.Query7(serverURL)),
                Task<Response8?>.Run(() => _userService.Query8(serverURL)),
                Task<Response8?>.Run(() => _userService.Query9(serverURL)),
                Task<Response8?>.Run(() => _userService.Query10(serverURL)),
                Task<Response11?>.Run(() => _authService.Query11(serverURL)),
                Task<Response12?>.Run(() => _authService.Query12(serverURL)),
                Task<Response13?>.Run(() => _authService.Query13(serverURL)),
                Task<Response12?>.Run(() => _authService.Query14(serverURL)),
                Task<Response1?>.Run(() => _userService.Query15(serverURL)));
        }
    }
}
