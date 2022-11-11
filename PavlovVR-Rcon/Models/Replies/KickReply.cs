namespace PavlovVR_Rcon.Models.Replies;

public class KickReply : BaseReply
{
    public bool Kick { get; init; }
    public ulong UniqueId { get; init; }
}
