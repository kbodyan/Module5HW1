using HttpFirst.Resources;
using HttpFirst.Responses;

namespace HttpFirst
{
    public class ResourceService : IResourceService
    {
        private IHttpService _httpService;

        public ResourceService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<Response4?> Query4(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/unknown";
            return await _httpService.SendAsync<object, Response4>(uri, httpMethod, null);
        }

        public async Task<Resource?> Query5(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/unknown/2";
            return await _httpService.SendAsync<object, Resource>(uri, httpMethod, null);
        }

        public async Task<Resource?> Query6(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/unknown/23";
            return await _httpService.SendAsync<object, Resource>(uri, httpMethod, null);
        }
    }
}
