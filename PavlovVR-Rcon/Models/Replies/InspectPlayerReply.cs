using PavlovVR_Rcon.Models.Pavlov;

namespace PavlovVR_Rcon.Models.Replies;

public class InspectPlayerReply : BaseReply
{
    public PlayerDetail PlayerInfo { get; init; } = new();
}
