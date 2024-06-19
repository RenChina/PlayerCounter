using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using SingletonAndTransientTest.Services.API;
using System;

namespace SingletonAndTransientTest.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Transient)]
public sealed class TransientService : ITransientService
{
    private string _guid;

    public TransientService()
    {
        _guid = Guid.NewGuid().ToString();
    }

    public string GetGuid()
    {
        return _guid; 
    }
}
