using Cysharp.Threading.Tasks;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;
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
        await PrintAsync($"ваша статистика: {playerCounter.killZombie}"); 
    }
}
