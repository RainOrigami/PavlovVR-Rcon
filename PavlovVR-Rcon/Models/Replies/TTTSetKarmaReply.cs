namespace PavlovVR_Rcon.Models.Replies;

public class TTTSetKarmaReply : BaseReply
{
    public bool TTTSetKarma { get; init; }
    public ulong UniqueId { get; init; }
    public int Karma { get; init; }
}
