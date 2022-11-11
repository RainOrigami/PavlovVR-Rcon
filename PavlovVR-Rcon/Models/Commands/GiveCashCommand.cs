using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class GiveCashCommand : BaseCommand<GiveCashReply>
{
    public GiveCashCommand(ulong uniqueId, int amount) : base("GiveCash")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(amount.ToString());
    }
}
