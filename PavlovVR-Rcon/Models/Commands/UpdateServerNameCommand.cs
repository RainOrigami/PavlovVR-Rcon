using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class UpdateServerNameCommand : BaseCommand<UpdateServerNameReply>
    {
        public UpdateServerNameCommand() : base("UpdateServerName")
        {
        }
    }
}
