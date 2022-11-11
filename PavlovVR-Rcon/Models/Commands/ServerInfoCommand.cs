using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class ServerInfoCommand : BaseCommand<ServerInfoReply>
{
    public ServerInfoCommand() : base("ServerInfo") { }
}
