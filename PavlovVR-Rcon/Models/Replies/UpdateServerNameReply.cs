namespace PavlovVR_Rcon.Models.Replies
{
    public class UpdateServerNameReply : BaseReply
    {
        public string ServerName { get; init; } = string.Empty;
        public bool UpdateServerName { get; init; }
    }
}
