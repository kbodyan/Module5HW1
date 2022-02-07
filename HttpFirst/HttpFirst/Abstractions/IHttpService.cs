
namespace HttpFirst
{
    public interface IHttpService
    {
        Task<TResult?> SendAsync<TPayload, TResult>(string uri, HttpMethod httpMethod, TPayload? payload);
    }
}