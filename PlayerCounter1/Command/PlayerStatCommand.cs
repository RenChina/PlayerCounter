using Cysharp.Threading.Tasks;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;
using OpenMod.Unturned.Users;
using PlayerCounter1.Services.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerCounter1.Command;


[Command("statzom")]
[CommandAlias("sz")]
public class PlayerStatCommand(IServiceProvider serviceProvider, IPlayerCounter playerCounter) : UnturnedCommand(serviceProvider)
{
    protected override async UniTask OnExecuteAsync()
    {
        var user = (UnturnedUser)Context.Actor;
        var steamIdPlayer = user!.SteamId;

        await PrintAsync($"ваша статистика: {playerCounter.GetPlayer(steamIdPlayer)}"); 
    }
}
