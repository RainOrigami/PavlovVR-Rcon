using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class ShutdownCommand : BaseCommand<ShutdownCommandReply>
{
    public ShutdownCommand() : base("Shutdown") { }
}
