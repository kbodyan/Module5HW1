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
    public class HttpService
    {
        public async Task<TResult?> SendAcync<TResult>(HttpRequestMessage httpRequestMessage)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.SendAsync(httpRequestMessage);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var respose = JsonConvert.DeserializeObject<TResult>(content);
                }

                return default(TResult);
            }
        }
    }
}
