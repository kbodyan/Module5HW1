using HttpFirst.Responses;
using HttpFirst.Users;

namespace HttpFirst
{
    public interface IUserService
    {
        Task<Response1?> Query1(string serverURL);
        Task<Response8?> Query10(string serverURL);
        Task<Response1?> Query15(string serverURL);
        Task<User?> Query2(string serverURL);
        Task<User?> Query3(string serverURL);
        Task<Response7?> Query7(string serverURL);
        Task<Response8?> Query8(string serverURL);
        Task<Response8?> Query9(string serverURL);
    }
}