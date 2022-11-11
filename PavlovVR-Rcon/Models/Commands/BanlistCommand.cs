using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class BanListCommand : BaseCommand<BanlistReply>
{
    public BanListCommand() : base("BanList") { }
}
