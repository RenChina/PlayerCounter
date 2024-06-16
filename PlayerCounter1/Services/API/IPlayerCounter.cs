using System.Collections.Generic;
using OpenMod.API.Ioc;
using Steamworks;

namespace PlayerCounter1.Services.API;

[Service]
public interface IPlayerCounter
{
    Dictionary<CSteamID, int> Player { get;}

    void killCounterIncrease(CSteamID steamID);

    int getCounter(CSteamID steamID); 

    void nullWhenPlayerDiss(CSteamID steamID);  
}
