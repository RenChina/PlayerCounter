using OpenMod.API.Ioc;
using OpenMod.Unturned.Players;
using Steamworks;
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

    Dictionary<CSteamID, int> Player { get;}

    void addCounterPlayer (CSteamID steamID, int count);

    bool GetPlayer(CSteamID steamID, int count); 
}
