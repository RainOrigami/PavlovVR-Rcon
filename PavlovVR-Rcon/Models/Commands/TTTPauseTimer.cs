using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class TTTPauseTimer : BaseCommand<TTTPauseTimerReply>
{
    public TTTPauseTimer() : base("tttpausetimer") { }
}
