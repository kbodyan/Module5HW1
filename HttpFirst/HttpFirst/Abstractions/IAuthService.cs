using HttpFirst.Responses;

namespace HttpFirst
{
    public interface IAuthService
    {
        Task<Response11?> Query11(string serverURL);
        Task<Response12?> Query12(string serverURL);
        Task<Response13?> Query13(string serverURL);
        Task<Response12?> Query14(string serverURL);
    }
}