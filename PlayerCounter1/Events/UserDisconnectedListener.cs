using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.Connections.Events;
using PlayerCounter1.Services.API;
using System;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

public class UserDisconnectedListener(IServiceProvider serviceProvider, IPlayerCounter playerCounter) : IEventListener<UnturnedPlayerDisconnectedEvent>
{

    public Task HandleEventAsync(object? sender, UnturnedPlayerDisconnectedEvent @event)
    {
        playerCounter.nullWhenPlayerDiss(@event.Player.SteamId); 

        return Task.CompletedTask;
    }
}
