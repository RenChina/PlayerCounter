using Microsoft.Extensions.DependencyInjection;
using PlayerCounter1.Services.API;
using System.Collections.Generic;
using OpenMod.API.Ioc;
using Steamworks;

namespace PlayerCounter1.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public class PlayerCounterService : IPlayerCounter
{
    private readonly Dictionary<CSteamID, int> _player = new Dictionary<CSteamID, int>();

    public Dictionary<CSteamID, int> Player => _player;

    public int getCounter(CSteamID steamID)
    {
        if (_player.TryGetValue(steamID, out var count))
        {
            return count;
        }
        return 0;
    }

    public void killCounterIncrease(CSteamID steamID)
    {
        if (_player.ContainsKey(steamID))
        {
            _player[steamID]++;
        }
        else
        {
            _player[steamID] = 1;
        }
    }


    public void nullWhenPlayerDiss(CSteamID steamID)
    {
        if (_player.ContainsKey(steamID))
        {
            _player[steamID] = 0; 
        }
    }
}