using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SetPinCommand : BaseCommand<SetPinReply>
{
    public SetPinCommand(int? pin) : base("SetPin")
    {
        if (pin.HasValue)
        {
            this.addParameter(pin.Value.ToString());
        }
    }
}
