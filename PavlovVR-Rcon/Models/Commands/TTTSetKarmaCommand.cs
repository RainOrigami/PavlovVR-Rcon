using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class TTTSetKarmaCommand : BaseCommand<TTTSetKarmaReply>
{
    public TTTSetKarmaCommand(ulong uniqueId, int karma) : base("tttsetkarma")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(karma.ToString());
    }
}
