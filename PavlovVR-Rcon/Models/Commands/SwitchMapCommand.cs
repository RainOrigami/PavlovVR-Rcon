using PavlovVR_Rcon.Models.Pavlov;
using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SwitchMapCommand : BaseCommand<SwitchMapReply>
{
    public SwitchMapCommand(string mapLabel, GameMode gameMode) : base("SwitchMap")
    {
        this.addParameter(mapLabel);
        this.addParameter(gameMode.ToString());
    }

    public SwitchMapCommand(int workshopMapId, GameMode gameMode) : base("SwitchMap")
    {
        this.addParameter($"UGC{workshopMapId}");
        this.addParameter(gameMode.ToString());
    }
}
