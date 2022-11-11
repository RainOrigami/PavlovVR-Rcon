namespace PavlovVR_Rcon.Models.Replies;

public class BanlistReply : BaseReply
{
    public ulong[] BanList { get; init; } = Array.Empty<ulong>();
}
