using OpenMod.API.Ioc;
using OpenMod.Unturned.Players;
using Steamworks;

namespace PlayerCounter1.Services.API;

[Service]
public interface IPlayerCounterService
{
    void IncreaseKillCounter(UnturnedPlayer player);

    int GetCounter(UnturnedPlayer player); 

    void ResetCounter(UnturnedPlayer player);  
}
