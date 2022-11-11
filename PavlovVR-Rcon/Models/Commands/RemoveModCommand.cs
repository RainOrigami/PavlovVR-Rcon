using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class RemoveModCommand : BaseCommand<RemoveModReply>
{
    public RemoveModCommand(ulong uniqueId) : base("RemoveMod")
    {
        this.addParameter(uniqueId.ToString());
    }
}
