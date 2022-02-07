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

namespace HttpFirst
{
    public class HttpService : IHttpService
    {
        public async Task<TResult?> SendAsync<TPayload, TResult>(string uri, HttpMethod httpMethod, TPayload? payload)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);
                if (payload is not object && payload != null)
                {
                    httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                }

                var result = await httpClient.SendAsync(httpRequestMessage);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var respose = JsonConvert.DeserializeObject<TResult>(content);
                    return respose;
                }

                return default(TResult);
            }
        }
    }
}
