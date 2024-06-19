using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.Connections.Events;
using SingletonAndTransientTest.Services.API;
using System.Threading.Tasks;

namespace SingletonAndTransientTest.Events;

public sealed class UserConecctedListenerTransient(ITransientService transientService) : IEventListener<UnturnedPlayerConnectedEvent>
{
    public Task HandleEventAsync(object? sender, UnturnedPlayerConnectedEvent @event)
    {
        transientService.GetGuid(); 
        
        return Task.CompletedTask;
    }
}
