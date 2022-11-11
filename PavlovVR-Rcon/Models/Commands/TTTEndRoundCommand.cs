using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class TTTEndRoundCommand : BaseCommand<TTTEndRoundReply>
{
    public TTTEndRoundCommand() : base("tttendround") { }
}
