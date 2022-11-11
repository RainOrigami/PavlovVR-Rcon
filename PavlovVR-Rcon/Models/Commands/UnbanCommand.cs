using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class UnbanCommand : BaseCommand<UnbanReply>
{
    public UnbanCommand(ulong uniqueId) : base("Unban")
    {
        this.addParameter(uniqueId.ToString());
    }
}
