using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpFirst.Users;

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
            var result = await _httpService.SendAsync<object, Response1>(uri, httpMethod, null);
            return result;
        }

        public async Task<User?> Query2(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/users/2";
            var result = await _httpService.SendAsync<object, User>(uri, httpMethod, null);
            return result;
        }

        public async Task<User?> Query3(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/users/23";
            var result = await _httpService.SendAsync<object, User>(uri, httpMethod, null);
            return result;
        }
    }
}
