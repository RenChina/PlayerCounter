using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.Connections.Events;
using PlayerCounter1.Services.API;
using System;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

public sealed class UserDisconnectedListener(IServiceProvider serviceProvider, IPlayerCounter playerCounter) : IEventListener<UnturnedPlayerDisconnectedEvent>
{
    public Task HandleEventAsync(object? sender, UnturnedPlayerDisconnectedEvent @event)
    {
        playerCounter.NullWhenPlayerDisconnected(@event!.Player.SteamId); 

        return Task.CompletedTask;
    }
}
