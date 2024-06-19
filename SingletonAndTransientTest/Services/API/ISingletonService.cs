using OpenMod.API.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAndTransientTest.Services.API;

[Service]
public interface ISingletonService
{
    string GetGuid();
}
