using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class RefreshListCommand : BaseCommand<RefreshListReply>
{
    public RefreshListCommand() : base("RefreshList") { }
}
