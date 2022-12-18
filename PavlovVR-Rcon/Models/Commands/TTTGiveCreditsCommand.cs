using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class TTTGiveCreditsCommand : BaseCommand<TTTGiveCreditsReply>
    {
        public TTTGiveCreditsCommand() : base("TTTGiveCredits")
        {
        }
    }
}
