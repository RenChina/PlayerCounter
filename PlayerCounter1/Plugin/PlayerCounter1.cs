using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OpenMod.API.Plugins;
using OpenMod.Unturned.Plugins;
using System;

[assembly: PluginMetadata("PlayerCounter1", DisplayName = "PlayerCounter1")]

namespace PlayerCounter1.Plugin;

public sealed class MyOpenModPlugin : OpenModUnturnedPlugin
{
    private readonly ILogger<MyOpenModPlugin> m_logger;

    public MyOpenModPlugin(ILogger<MyOpenModPlugin> logger, IServiceProvider serviceProvider) : base(serviceProvider)
    {
        m_logger = logger;
    }

    protected override UniTask OnLoadAsync()
    {
        m_logger.LogInformation("Made by RenatChina for Migliore RP Servers!");
        m_logger.LogInformation("Discord: allax.");

        return UniTask.CompletedTask;
    }
}

