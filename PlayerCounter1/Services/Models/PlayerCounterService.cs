using Microsoft.Extensions.DependencyInjection;
using PlayerCounter1.Services.API;
using System.Collections.Generic;
using OpenMod.API.Ioc;
using Steamworks;

namespace PlayerCounter1.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public sealed class PlayerCounterService : IPlayerCounter
{
    private readonly Dictionary<CSteamID, int> _player = new();

    public Dictionary<CSteamID, int> Player => _player;

    public int GetCounter(CSteamID steamID)
    {
        if (_player.TryGetValue(steamID, out var count))
        {
            return count;
        }
        return 0;
    }
    
    public void KillCounterIncrease(CSteamID steamID)
    {
        if (_player.ContainsKey(steamID))
        {
            _player[steamID]++;
        }
    }

    public void NullWhenPlayerDisconnected(CSteamID steamID)
    {
        if (_player.ContainsKey(steamID))
        {
            _player[steamID] = 0; 
        }
    }
}