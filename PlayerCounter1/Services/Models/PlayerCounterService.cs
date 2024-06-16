using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using OpenMod.Unturned.Players;
using PlayerCounter1.Services.API;
using Serilog.Formatting.Json;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerCounter1.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public class PlayerCounterService : IPlayerCounter
{
    private int count = 0;

    private readonly Dictionary<CSteamID, int> _player = new Dictionary<CSteamID, int>();

    public int killZombie
    {
        get
        {
            return count;
        }

        set
        {
            count = value;
        }
    }

    public Dictionary<CSteamID, int> Player => _player;

    public int GetPlayer(CSteamID steamID)
    {
        if (_player.TryGetValue(steamID, out var count))
        {
            return count;
        }
        return 0;
    }

    public void addCounterPlayer(CSteamID steamID)
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