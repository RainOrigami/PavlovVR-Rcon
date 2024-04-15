using PavlovVR_Rcon.Models.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavlovVR_Rcon.Models.Commands
{
    public class ClearEmptyVehiclesCommand : BaseCommand<ClearEmptyVehiclesReply>
    {
        public ClearEmptyVehiclesCommand() : base("ClearEmptyVehicles")
        {
        }
    }
}
