using PavlovVR_Rcon.Models.Pavlov;
using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class GiveVehicleCommand : BaseCommand<GiveVehicleReply>
{
    public GiveVehicleCommand(ulong uniqueId, Vehicle vehicle) : base("GiveVehicle")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(vehicle.ToString());
    }

    public GiveVehicleCommand(ulong uniqueId, string customVehicleName) : base("GiveVehicle")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(customVehicleName);
    }
}
