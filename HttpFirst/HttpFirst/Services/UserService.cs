using HttpFirst.Users;
using HttpFirst.Requests;
using HttpFirst.Responses;

namespace HttpFirst
{
    public class UserService : IUserService
    {
        private IHttpService _httpService;

        public UserService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<Response1?> Query1(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/users?page=2";
            return await _httpService.SendAsync<object, Response1>(uri, httpMethod, null);
        }

        public async Task<User?> Query2(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/users/2";
            return await _httpService.SendAsync<object, User>(uri, httpMethod, null);
        }

        public async Task<User?> Query3(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/users/23";
            return await _httpService.SendAsync<object, User>(uri, httpMethod, null);
        }

        public async Task<Response7?> Query7(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Post;
            var uri = $"{serverURL}/api/users";
            var request = new Request7 { Name = "morpheus", Job = "leader" };
            return await _httpService.SendAsync<Request7, Response7>(uri, httpMethod, request);
        }

        public async Task<Response8?> Query8(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Put;
            var uri = $"{serverURL}/api/users/2";
            var request = new Request7 { Name = "morpheus", Job = "zion resident" };
            return await _httpService.SendAsync<Request7, Response8>(uri, httpMethod, request);
        }

        public async Task<Response8?> Query9(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Patch;
            var uri = $"{serverURL}/api/users/2";
            var request = new Request7 { Name = "morpheus", Job = "zion resident" };
            return await _httpService.SendAsync<Request7, Response8>(uri, httpMethod, request);
        }

        public async Task<Response8?> Query10(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Delete;
            var uri = $"{serverURL}/api/users/2";
            return await _httpService.SendAsync<object, Response8>(uri, httpMethod, null);
        }

        public async Task<Response1?> Query15(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/users?delay=3";
            return await _httpService.SendAsync<object, Response1>(uri, httpMethod, null);
        }
    }
}
