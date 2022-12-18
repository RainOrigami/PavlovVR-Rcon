using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class ShutdownServerCommand : BaseCommand<ShutdownServerReply>
    {
        public ShutdownServerCommand() : base("ShutdownServer")
        {
        }
    }
}
