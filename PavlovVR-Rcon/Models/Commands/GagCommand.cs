using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class GagCommand : BaseCommand<GagReply>
{
    public GagCommand(ulong uniqueId) : base("Gag")
    {
        this.addParameter(uniqueId.ToString());
    }
}
