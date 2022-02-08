using HttpFirst.Resources;
using HttpFirst.Responses;

namespace HttpFirst
{
    public interface IResourceService
    {
        Task<Response4?> Query4(string serverURL);
        Task<Resource?> Query5(string serverURL);
        Task<Resource?> Query6(string serverURL);
    }
}