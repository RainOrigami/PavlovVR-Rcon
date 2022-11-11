using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class GiveTeamCashCommand : BaseCommand<GiveTeamCashReply>
{
    public GiveTeamCashCommand(int teamId, int amount) : base("GiveTeamCash")
    {
        this.addParameter(teamId.ToString());
        this.addParameter(amount.ToString());
    }
}
