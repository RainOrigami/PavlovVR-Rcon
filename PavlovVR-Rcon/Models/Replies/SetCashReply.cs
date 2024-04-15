namespace PavlovVR_Rcon.Models.Replies;

public class SetCashReply : BaseReply
{
    public bool SetCash { get; init; }
    public ulong UniqueId { get; init; }
}
