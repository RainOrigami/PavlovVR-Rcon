using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class EnableVerboseLoggingCommand : BaseCommand<EnableVerboseLoggingReply>
    {
        public EnableVerboseLoggingCommand() : base("EnableVerboseLogging")
        {
        }
    }
}
