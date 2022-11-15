using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class TTTPauseTimerCommand : BaseCommand<TTTPauseTimerReply>
{
    public TTTPauseTimerCommand() : base("tttpausetimer") { }
}
