namespace PavlovVR_Rcon.Models.Replies;

public class SetPlayerSkinReply : BaseReply
{
    public bool SetPlayerSkin { get; init; }
    public ulong UniqueId { get; init; }
}
