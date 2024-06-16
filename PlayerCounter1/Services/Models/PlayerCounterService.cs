using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using OpenMod.Unturned.Players;
using PlayerCounter1.Services.API;
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

    public Dictionary<CSteamID, int> Player => _player;
   
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


    public bool GetPlayer(CSteamID steamID, out int count)
    {
        return _player.TryGetValue(steamID, out count);
    }

    public void addCounterPlayer(CSteamID steamID, int count)
    {
        _player[steamID] = count;
    }
    
}