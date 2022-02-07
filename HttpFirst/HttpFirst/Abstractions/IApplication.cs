using Microsoft.Extensions.Configuration;

namespace HttpFirst
{
    public interface IApplication
    {
        Task Run(IConfigurationRoot config);
    }
}