using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class RemoveMapRotationCommand : BaseCommand<RemoveMapRotationReply>
    {
        public RemoveMapRotationCommand() : base("RemoveMapRotation")
        {
        }
    }
}
