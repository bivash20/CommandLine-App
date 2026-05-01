using System.Threading.Tasks;
using PlatformService.DTOs;

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat); 
        Task GetFromCommandToPlatform();
    }
}