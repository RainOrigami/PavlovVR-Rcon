using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class SetBalanceTableURLCommand : BaseCommand<SetBalanceTableURLReply>
    {
        public SetBalanceTableURLCommand() : base("SetBalanceTableURL")
        {
        }
    }
}
