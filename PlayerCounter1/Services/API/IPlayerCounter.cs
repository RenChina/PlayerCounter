using OpenMod.API.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCounter1.Services.API;

[Service]
public interface IPlayerCounter
{
    int killZombie { get; set; }
}
