using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpFirst.Resources;

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
            var result = await _httpService.SendAsync<object, Response4>(uri, httpMethod, null);
            return result;
        }

        public async Task<Resource?> Query5(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/unknown/2";
            var result = await _httpService.SendAsync<object, Resource>(uri, httpMethod, null);
            return result;
        }

        public async Task<Resource?> Query6(string serverURL)
        {
            HttpMethod httpMethod = HttpMethod.Get;
            var uri = $"{serverURL}/api/unknown/23";
            var result = await _httpService.SendAsync<object, Resource>(uri, httpMethod, null);
            return result;
        }
    }
}
