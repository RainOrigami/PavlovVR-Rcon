using PavlovVR_Rcon.Models.Pavlov;

namespace PavlovVR_Rcon.Models.Replies;

public class ServerInfoReply : BaseReply
{
    public ServerInfo ServerInfo { get; init; } = new();
}
