using OpenMod.API.Ioc;
using Steamworks;

namespace PlayerCounter1.Services.API;

[Service]
public interface IPlayerCounter
{
    void KillCounterIncrease(CSteamID steamID);

    int GetCounter(CSteamID steamID); 

    void NullWhenPlayerDisconnected(CSteamID steamID);  
}
