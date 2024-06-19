using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using SingletonAndTransientTest.Services.API;
using System;

namespace SingletonAndTransientTest.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public class SingletonService : ISingletonService
{
    private string _guid;

    public SingletonService()
    {
        _guid = Guid.NewGuid().ToString();
    }

    public string GetGuid()
    {
        return _guid;
    }
}
