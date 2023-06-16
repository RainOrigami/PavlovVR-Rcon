namespace PavlovVR_Rcon.Models.Replies
{
    public class TTTSetRoleReply : BaseReply
    {
        public bool TTTSetRole { get; init; }
        public ulong UniqueID { get; init; }
        public string Role { get; init; }
    }
}
