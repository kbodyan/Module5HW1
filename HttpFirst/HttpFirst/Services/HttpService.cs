using System.Text;
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
                if (payload != null)
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
