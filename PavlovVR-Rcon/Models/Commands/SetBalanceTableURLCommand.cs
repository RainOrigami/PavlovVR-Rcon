using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class SetBalanceTableURLCommand : BaseCommand<SetBalanceTableURLReply>
    {
        public SetBalanceTableURLCommand(string url) : base("SetBalanceTableURL")
        {
            this.addParameter(url);
        }
    }
}
