using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class InspectPlayerCommand : BaseCommand<InspectPlayerReply>
{
    public InspectPlayerCommand(ulong uniqueId) : base("InspectPlayer")
    {
        this.addParameter(uniqueId.ToString());
    }
}
