using PavlovVR_Rcon.Models.Pavlov;
using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class SetLimitedAmmoTypeCommand : BaseCommand<SetLimitedAmmoTypeReply>
{
    public SetLimitedAmmoTypeCommand(AmmoType ammoType) : base("SetLimitedAmmoType")
    {
        this.addParameter(((int) ammoType).ToString());
    }
}
