using PavlovVR_Rcon.Models.Pavlov;

namespace PavlovVR_Rcon.Models.Replies
{
    public class InspectTeamReply : BaseReply
    {
        public PlayerDetail[] InspectList { get; init; } = Array.Empty<PlayerDetail>();
    }
}
