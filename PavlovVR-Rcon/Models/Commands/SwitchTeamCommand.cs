using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SwitchTeamCommand : BaseCommand<SwitchTeamReply>
{
    public SwitchTeamCommand(ulong uniqueId, int teamId) : base("SwitchTeam")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(teamId.ToString());
    }
}
