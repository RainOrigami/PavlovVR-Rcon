namespace PavlovVR_Rcon.Models.Replies
{
    public class SetTimeLimitReply : BaseReply
    {
        public bool SetTimeLimit { get; init; }
        public int TimeLimit { get; init; }
    }
}
