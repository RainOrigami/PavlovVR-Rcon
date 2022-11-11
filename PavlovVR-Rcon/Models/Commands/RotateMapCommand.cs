using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class RotateMapCommand : BaseCommand<RotateMapReply>
{
    public RotateMapCommand() : base("RotateMap") { }
}
