using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class PauseMatchCommand : BaseCommand<PauseMatchReply>
    {
        public PauseMatchCommand(int amount) : base("PauseMatch")
        {
            this.addParameter(amount.ToString());
        }
    }
}
