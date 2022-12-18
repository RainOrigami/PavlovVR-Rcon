using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class SetMaxPlayersCommand : BaseCommand<SetMaxPlayersReply>
    {
        public SetMaxPlayersCommand() : base("SetMaxPlayers")
        {
        }
    }
}
