namespace PavlovVR_Rcon.Models.Replies;

public class RemoveModReply : BaseReply
{
    public bool RemoveMod { get; init; }
    public ulong UniqueId { get; init; }
}
