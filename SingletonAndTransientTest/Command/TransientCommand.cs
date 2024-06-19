using Cysharp.Threading.Tasks;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;
using SingletonAndTransientTest.Services.API;
using System;
namespace SingletonAndTransientTest.Command;

[Command("transient")]
public sealed class TransientCommand(IServiceProvider serviceProvider, ITransientService transientService) : UnturnedCommand(serviceProvider)
{
    protected override async UniTask OnExecuteAsync()
    {
        var guid = transientService.GetGuid();

        await PrintAsync($"Guid меняется при каждом вызове: {guid}");
    }
}
