using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class BanCommand : BaseCommand<BanReply>
{
    public BanCommand(ulong uniqueId) : base("Ban")
    {
        this.addParameter(uniqueId.ToString());
    }
}
