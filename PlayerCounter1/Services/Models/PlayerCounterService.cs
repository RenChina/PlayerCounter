using Microsoft.Extensions.DependencyInjection;
using PlayerCounter1.Services.API;
using System.Collections.Generic;
using OpenMod.API.Ioc;
using Steamworks;
using OpenMod.Unturned.Players;
using YamlDotNet.Core.Tokens;

namespace PlayerCounter1.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public sealed class PlayerCounterService : IPlayerCounterService
{
    private readonly Dictionary<UnturnedPlayer, int> _playerCounters = [];
 
    public int GetCounter(UnturnedPlayer player)
    {
        return (_playerCounters.TryGetValue(player, out var count)) ? count : 1; 
    }
    
    public void IncreaseKillCounter(UnturnedPlayer player)
    {
        if (_playerCounters.ContainsKey(player))
        {
            _playerCounters[player]++;
        }
    }

    public void ResetCounter(UnturnedPlayer player)
    {
        if (_playerCounters.ContainsKey(player))
        {
            _playerCounters[player] = 0; 
        }
    }
}