using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Eventing;
using OpenMod.Core.Eventing;
using OpenMod.Unturned.Zombies.Events;
using PlayerCounter1.Services.API;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

[EventListenerLifetime(ServiceLifetime.Singleton)]
public sealed class PlayerKillStat(IPlayerCounter playerCounter) : IEventListener<UnturnedZombieDyingEvent>
{
    public async Task HandleEventAsync(object? sender, UnturnedZombieDyingEvent @event)
    {
        if (@event.Instigator is null) return; 
            
        var steamPlayer = @event!.Instigator.SteamId;

        playerCounter.KillCounterIncrease(steamPlayer);
    }
}
