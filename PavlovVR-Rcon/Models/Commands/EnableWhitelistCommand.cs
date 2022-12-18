using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class EnableWhitelistCommand : BaseCommand<EnableWhitelistReply>
    {
        public EnableWhitelistCommand() : base("EnableWhitelist")
        {
        }
    }
}
