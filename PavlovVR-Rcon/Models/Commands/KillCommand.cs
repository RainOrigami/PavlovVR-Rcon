using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class KillCommand : BaseCommand<KillReply>
{
    public KillCommand(ulong uniqueId) : base("Kill")
    {
        this.addParameter(uniqueId.ToString());
    }
}
