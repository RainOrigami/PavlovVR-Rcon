using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class InspectAllCommand : BaseCommand<InspectAllReply>
    {
        public InspectAllCommand() : base("InspectAll")
        {
        }
    }
}
