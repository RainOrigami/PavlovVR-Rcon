namespace PavlovVR_Rcon.Models.Replies
{
    public class SetMaxPlayersReply : BaseReply
    {
        public bool SetMaxPlayers { get; init; }
        public int MaxPlayers { get; init; }
    }
}
