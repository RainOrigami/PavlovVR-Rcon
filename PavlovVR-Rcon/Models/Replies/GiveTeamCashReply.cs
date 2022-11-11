namespace PavlovVR_Rcon.Models.Replies;

public class GiveTeamCashReply : BaseReply
{
    public bool GiveTeamCash { get; init; }
    public int TeamId { get; init; }
}
