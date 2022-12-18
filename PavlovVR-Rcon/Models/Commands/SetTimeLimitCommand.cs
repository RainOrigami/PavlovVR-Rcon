using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class SetTimeLimitCommand : BaseCommand<SetTimeLimitReply>
    {
        public SetTimeLimitCommand() : base("SetTimeLimit")
        {
        }
    }
}
