using Microsoft.Extensions.DependencyInjection;
using PlayerCounter1.Services.API;
using System.Collections.Generic;
using OpenMod.API.Ioc;
using Steamworks;

namespace PlayerCounter1.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public sealed class PlayerCounterService : IPlayerCounterService
{
    private readonly Dictionary<CSteamID, int> _playerCounters = new();

    public Dictionary<CSteamID, int> PlayerCounters => _playerCounters;

    public int GetCounter(CSteamID steamID)
    {
        if (_playerCounters.TryGetValue(steamID, out var count))
        {
            return count;
        }
        return 0;
    }
    
    public void IncreaseKillCounter(CSteamID steamID)
    {
        if (_playerCounters.ContainsKey(steamID))
        {
            _playerCounters[steamID]++;
        }
    }

    public void ReturnNullWhenPlayerDisconnected(CSteamID steamID)
    {
        if (_playerCounters.ContainsKey(steamID))
        {
            _playerCounters[steamID] = 0; 
        }
    }
}