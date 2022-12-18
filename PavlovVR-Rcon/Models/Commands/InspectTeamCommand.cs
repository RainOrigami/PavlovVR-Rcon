using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class InspectTeamCommand : BaseCommand<InspectTeamReply>
    {
        public InspectTeamCommand() : base("InspectTeam")
        {
        }
    }
}
