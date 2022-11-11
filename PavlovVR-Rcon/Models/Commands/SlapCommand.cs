using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SlapCommand : BaseCommand<SlapReply>
{
    public SlapCommand(ulong uniqueId, int amount) : base("Slap")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(amount.ToString());
    }
}
