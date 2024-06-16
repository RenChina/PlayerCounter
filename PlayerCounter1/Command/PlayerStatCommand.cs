using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;
using OpenMod.Unturned.Users;
using PlayerCounter1.Services.API;
using System;

namespace PlayerCounter1.Command;

[Command("statzom")]
[CommandAlias("sz")]
public sealed class PlayerStatCommand : UnturnedCommand
{
    private readonly IConfiguration m_configuration;
    private readonly IPlayerCounter m_playerCounter;

    public PlayerStatCommand(IServiceProvider serviceProvider, IPlayerCounter playerCounter, IConfiguration configuration) : base(serviceProvider)
    {
        m_configuration = configuration;
        m_playerCounter = playerCounter;
    }

    protected override async UniTask OnExecuteAsync()
    {
        var user = (UnturnedUser)Context.Actor;
        var steamIdPlayer = user!.SteamId;

        var changeableMessage = m_configuration["message_when_command"];

        await PrintAsync($"{changeableMessage}{m_playerCounter.GetCounter(steamIdPlayer)}"); 
    }
}
