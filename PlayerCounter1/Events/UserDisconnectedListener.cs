using OpenMod.Unturned.Players.Connections.Events;
using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Eventing;
using OpenMod.Core.Eventing;
using PlayerCounter1.Services.API;
using System;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

[EventListenerLifetime(ServiceLifetime.Singleton)]
public sealed class UserDisconnectedListener(IServiceProvider serviceProvider, IPlayerCounterService playerCounter) : IEventListener<UnturnedPlayerDisconnectedEvent>
{
    public Task HandleEventAsync(object? sender, UnturnedPlayerDisconnectedEvent @event)
    {
        playerCounter.ResetCounter(@event!.Player); 

        return Task.CompletedTask;
    }
}
