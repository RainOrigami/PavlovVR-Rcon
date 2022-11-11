using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class TTTAlwaysEnableSkinMenuCommand : BaseCommand<TTTAlwaysEnableSkinMenuReply>
{
    public TTTAlwaysEnableSkinMenuCommand() : base("TTTAlwaysEnableSkinMenu") { }
}
