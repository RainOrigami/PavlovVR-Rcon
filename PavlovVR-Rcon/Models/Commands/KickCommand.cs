using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class KickCommand : BaseCommand<KickReply>
{
    public KickCommand(ulong uniqueId) : base("Kick")
    {
        this.addParameter(uniqueId.ToString());
    }
}
