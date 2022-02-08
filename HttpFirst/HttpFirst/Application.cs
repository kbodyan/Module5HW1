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
            var result1 = Task<Response1?>.Run(() => _userService.Query1(serverURL));
            var result2 = Task<User?>.Run(() => _userService.Query2(serverURL));
            var result3 = Task<User?>.Run(() => _userService.Query3(serverURL));
            var result4 = Task<Response4?>.Run(() => _resourceService.Query4(serverURL));
            var result5 = Task<Resource?>.Run(() => _resourceService.Query5(serverURL));
            var result6 = Task<Resource?>.Run(() => _resourceService.Query6(serverURL));
            var result7 = Task<Response7?>.Run(() => _userService.Query7(serverURL));
            var result8 = Task<Response8?>.Run(() => _userService.Query8(serverURL));
            var result9 = Task<Response8?>.Run(() => _userService.Query9(serverURL));
            var result10 = Task<Response8?>.Run(() => _userService.Query10(serverURL));
            var result11 = Task<Response11?>.Run(() => _authService.Query11(serverURL));
            var result12 = Task<Response12?>.Run(() => _authService.Query12(serverURL));
            var result13 = Task<Response13?>.Run(() => _authService.Query13(serverURL));
            var result14 = Task<Response12?>.Run(() => _authService.Query14(serverURL));
            var result15 = Task<Response1?>.Run(() => _userService.Query15(serverURL));

            await Task.WhenAll(
                result1,
                result2,
                result3,
                result4,
                result5,
                result6,
                result7,
                result8,
                result9,
                result10,
                result11,
                result12,
                result13,
                result14,
                result14);

            var response1 = await result1;
            var response2 = await result2;
            var response3 = await result3;
            var response4 = await result4;
            var response5 = await result5;
            var response6 = await result6;
            var response7 = await result7;
            var response8 = await result8;
            var response9 = await result9;
            var response10 = await result10;
            var response11 = await result11;
            var response12 = await result12;
            var response13 = await result13;
            var response14 = await result14;
            var response15 = await result15;
        }
    }
}
