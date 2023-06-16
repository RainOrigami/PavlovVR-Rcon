namespace PavlovVR_Rcon.Models.Replies
{
    public class TeleportReply : BaseReply
    {
        public ulong MoveUniqueID { get; init; }
        public ulong ToUniqueID { get; init; }
        public bool Teleport { get; init; }
    }
}
