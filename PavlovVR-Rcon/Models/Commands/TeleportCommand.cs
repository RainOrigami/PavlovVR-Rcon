using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class TeleportCommand : BaseCommand<TeleportReply>
    {
        public TeleportCommand() : base("Teleport")
        {
        }
    }
}
