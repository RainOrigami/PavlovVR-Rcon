using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands
{
    public class TTTSetRoleCommand : BaseCommand<TTTSetRoleReply>
    {
        public TTTSetRoleCommand() : base("TTTSetRole")
        {
        }
    }
}
