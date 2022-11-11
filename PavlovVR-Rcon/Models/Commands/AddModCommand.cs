using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class AddModCommand : BaseCommand<AddModReply>
{
    public AddModCommand(ulong uniqueId) : base("AddMod")
    {
        this.addParameter(uniqueId.ToString());
    }
}
