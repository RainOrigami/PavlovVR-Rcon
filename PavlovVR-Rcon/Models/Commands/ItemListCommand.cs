using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public class ItemListCommand : BaseCommand<ItemListReply>
{
    public ItemListCommand() : base("ItemList") { }
}
