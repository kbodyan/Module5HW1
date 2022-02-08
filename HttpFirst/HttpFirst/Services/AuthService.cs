using HttpFirst.Requests;
using HttpFirst.Responses;

namespace HttpFirst
{
    public class AuthService : IAuthService
    {
        private IHttpService _httpService;
        public AuthService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<Response11?> Query11(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Post;
            var uri = $"{serverURL}/api/register";
            var request = new Request11 { Email = "eve.holt@reqres.in", Password = "pistol" };
            return await _httpService.SendAsync<Request11, Response11>(uri, httpMethod, request);
        }

        public async Task<Response12?> Query12(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Post;
            var uri = $"{serverURL}/api/register";
            var request = new Request12 { Email = "sydney@fife" };
            return await _httpService.SendAsync<Request12, Response12>(uri, httpMethod, request);
        }

        public async Task<Response13?> Query13(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Post;
            var uri = $"{serverURL}/api/login";
            var request = new Request11 { Email = "eve.holt@reqres.in", Password = "cityslicka" };
            return await _httpService.SendAsync<Request11, Response13>(uri, httpMethod, request);
        }

        public async Task<Response12?> Query14(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Post;
            var uri = $"{serverURL}/api/login";
            var request = new Request12 { Email = "peter@klaven" };
            return await _httpService.SendAsync<Request12, Response12>(uri, httpMethod, request);
        }
    }
}
