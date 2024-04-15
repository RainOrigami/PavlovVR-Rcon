using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class InspectTeamCommand : BaseCommand<InspectTeamReply>
    {
        public InspectTeamCommand(int teamId) : base("InspectTeam")
        {
            this.addParameter(teamId.ToString());
        }
    }
}
