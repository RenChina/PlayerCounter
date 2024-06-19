using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using OpenMod.API.Plugins;
using OpenMod.Unturned.Plugins;
using System;

[assembly: PluginMetadata("SingletonAndTransientTest", DisplayName = "SingletonAndTransientTest")]

namespace SingletonAndTransientTest.Plugin;

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
