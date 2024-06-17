using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Localization;
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
    private readonly IPlayerCounterService m_playerCounter;
    private readonly IStringLocalizer m_stringLocalizer;

    public PlayerStatCommand(IServiceProvider serviceProvider, IPlayerCounterService playerCounter, IStringLocalizer stringLocalizer) : base(serviceProvider)
    {
        m_playerCounter = playerCounter;
        m_stringLocalizer = stringLocalizer;
    }

    protected override async UniTask OnExecuteAsync()
    {
        var user = (UnturnedUser)Context.Actor;
        var steamIdPlayer = user!.SteamId;

        var changeableMessage = m_stringLocalizer["message_when_command"];

        await PrintAsync($"{changeableMessage}{m_playerCounter.GetCounter(steamIdPlayer)}"); 
    }
}
