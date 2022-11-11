namespace PavlovVR_Rcon.Models.Replies;

public class GiveVehicleReply : BaseReply
{
    public bool GiveVehicle { get; init; }
    public ulong UniqueId { get; init; }
}
