using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.Connections.Events;
using PlayerCounter1.Services.API;
using PlayerCounter1.Services.Models;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCounter1.Events;

public class UserConnectListener(IServiceProvider serviceProvider, IPlayerCounter playerCounter) : IEventListener<UnturnedPlayerDisconnectedEvent>
{

    public Task HandleEventAsync(object? sender, UnturnedPlayerDisconnectedEvent @event)
    {
        if (playerCounter.GetPlayer(@event.Player.SteamId, out int cout))
        {
            playerCounter.addCounterPlayer(@event.Player.SteamId, cout = 0);
        }

        return Task.CompletedTask;
    }
}
