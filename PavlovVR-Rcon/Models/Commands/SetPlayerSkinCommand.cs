using PavlovVR_Rcon.Models.Pavlov;
using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SetPlayerSkinCommand : BaseCommand<SetPlayerSkinReply>
{
    public SetPlayerSkinCommand(ulong uniqueId, Skin skin) : base("SetPlayerSkin")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(skin.ToString());
    }

    public SetPlayerSkinCommand(ulong uniqueId, string customSkinName) : base("SetPlayerSkin")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(customSkinName);
    }
}
