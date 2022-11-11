using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class ResetSNDCommand : BaseCommand<ResetSNDReply>
{
    public ResetSNDCommand() : base("ResetSND") { }
}
