using Cysharp.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Eventing;
using OpenMod.Core.Eventing;
using OpenMod.Unturned.Players.Stats.Events;
using OpenMod.Unturned.Zombies.Events;
using PlayerCounter1.Services.API;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

[EventListenerLifetime(ServiceLifetime.Singleton)]
public class PlayerKillStat(IPlayerCounter playerCounter) : IEventListener<UnturnedZombieDeadEvent>
{
    public async Task HandleEventAsync(object? sender, UnturnedZombieDeadEvent @event)
    {
        await @event.Zombie.KillAsync();
        playerCounter.killZombie += 1; 
    }
}
