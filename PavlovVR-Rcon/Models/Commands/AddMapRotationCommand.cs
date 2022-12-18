using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class AddMapRotationCommand : BaseCommand<AddMapRotationReply>
    {
        public AddMapRotationCommand() : base("AddMapRotation")
        {
        }
    }
}
