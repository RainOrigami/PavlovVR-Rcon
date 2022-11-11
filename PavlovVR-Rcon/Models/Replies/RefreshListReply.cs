using PavlovVR_Rcon.Models.Pavlov;

namespace PavlovVR_Rcon.Models.Replies;

public class RefreshListReply : BaseReply
{
    public Player[] PlayerList { get; init; } = Array.Empty<Player>();
}
