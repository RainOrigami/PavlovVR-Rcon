using PavlovVR_Rcon.Models.Pavlov;

namespace PavlovVR_Rcon.Models.Replies
{
    public class InspectAllReply : BaseReply
    {
        public PlayerDetail[] InspectList { get; init; } = Array.Empty<PlayerDetail>();
    }
}
