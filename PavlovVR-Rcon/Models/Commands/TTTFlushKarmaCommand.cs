using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class TTTFlushKarmaCommand : BaseCommand<TTTFlushKarmaReply>
{
    public TTTFlushKarmaCommand(ulong uniqueId) : base("tttflushkarma")
    {
        this.addParameter(uniqueId.ToString());
    }
}
