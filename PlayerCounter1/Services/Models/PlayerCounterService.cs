using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using PlayerCounter1.Services.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerCounter1.Services.Models;

[PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
public class PlayerCounterService : IPlayerCounter
{
    private int count = 0;

    public int killZombie
    {
       get
        {
            return count;
        }

        set
        {
            count = value;
        }
    }

}
