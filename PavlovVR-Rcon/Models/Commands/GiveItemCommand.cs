using PavlovVR_Rcon.Attributes;
using PavlovVR_Rcon.Models.Pavlov;
using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class GiveItemCommand : BaseCommand<GiveItemReply>
{
    public GiveItemCommand(ulong uniqueId, Item item) : base("GiveItem")
    {
        this.addParameter(uniqueId.ToString());

        StringValueOverrideAttribute? stringValueOverride = typeof(Item).GetField(Enum.GetName(typeof(Item), item)).GetCustomAttributes(false).OfType<StringValueOverrideAttribute>().SingleOrDefault();
        this.addParameter(stringValueOverride?.Value ?? item.ToString());
    }

    public GiveItemCommand(ulong uniqueId, string customItemName) : base("GiveItem")
    {
        this.addParameter(uniqueId.ToString());
        this.addParameter(customItemName);
    }
}
