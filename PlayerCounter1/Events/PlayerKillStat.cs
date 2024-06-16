using Cysharp.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Eventing;
using OpenMod.Core.Eventing;
using OpenMod.Unturned.Players;
using OpenMod.Unturned.Players.Stats.Events;
using OpenMod.Unturned.Zombies.Events;
using PlayerCounter1.Services.API;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

[EventListenerLifetime(ServiceLifetime.Singleton)]
public class PlayerKillStat(IPlayerCounter playerCounter) : IEventListener<UnturnedZombieDyingEvent>
{
    public async Task HandleEventAsync(object? sender, UnturnedZombieDyingEvent @event)
    {

        if (@event.Instigator == null || @event.Instigator is not UnturnedPlayer)
            return; 
            
        var steamPlayer = @event.Instigator.SteamId;


        if (playerCounter.GetPlayer(steamPlayer, out int cout))
        {
            playerCounter.addCounterPlayer(steamPlayer, cout + 1);
        }

    }
}
