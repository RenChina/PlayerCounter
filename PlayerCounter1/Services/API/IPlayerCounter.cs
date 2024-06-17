using OpenMod.API.Ioc;
using Steamworks;

namespace PlayerCounter1.Services.API;

[Service]
public interface IPlayerCounter
{
    void IncreaseKillCounter(CSteamID steamID);

    int GetCounter(CSteamID steamID); 

    void ReturnNullWhenPlayerDisconnected(CSteamID steamID);  
}
