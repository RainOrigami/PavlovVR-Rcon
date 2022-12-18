using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class EnableCompModeCommand : BaseCommand<EnableCompModeReply>
    {
        public EnableCompModeCommand() : base("EnableCompMode")
        {
        }
    }
}
