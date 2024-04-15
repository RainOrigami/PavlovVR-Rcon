using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SetCashCommand : BaseCommand<SetCashReply>
{
    public SetCashCommand(ulong uniqueId, int amount) : base("SetCash")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(amount.ToString());
    }
}
