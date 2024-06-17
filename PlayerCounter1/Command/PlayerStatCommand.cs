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
    private readonly IPlayerCounterService _playerCounter;
    private readonly IStringLocalizer _stringLocalizer;

    public PlayerStatCommand(IServiceProvider serviceProvider, IPlayerCounterService playerCounter, IStringLocalizer stringLocalizer) : base(serviceProvider)
    {
        _playerCounter = playerCounter;
        _stringLocalizer = stringLocalizer;
    }

    protected override async UniTask OnExecuteAsync()
    {
        var user = (UnturnedUser)Context.Actor;
        var steamIdPlayer = user!.SteamId;

        var playerCounter = _playerCounter.GetCounter;

        await PrintAsync(_stringLocalizer["message_when_command", new { counter = playerCounter }]);
    }
}
