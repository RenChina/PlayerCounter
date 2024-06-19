using Cysharp.Threading.Tasks;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;
using SingletonAndTransientTest.Services.API;
using System;

namespace SingletonAndTransientTest.Command;

[Command("singleton")]
public class SingletonCommand(IServiceProvider serviceProvider, ISingletonService singletonService) : UnturnedCommand(serviceProvider)
{
    protected override async UniTask OnExecuteAsync()
    {
        var guid = singletonService.GetGuid();
        
        await PrintAsync($"Уникальный гуид сервера, меняется после перезапуска: {guid}");
    }
}
