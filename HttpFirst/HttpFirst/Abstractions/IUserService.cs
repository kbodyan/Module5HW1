using HttpFirst.Users;

namespace HttpFirst
{
    public interface IUserService
    {
        Task<Response1?> Query1(string serverURL);
        Task<User?> Query2(string serverURL);
        Task<User?> Query3(string serverURL);
    }
}