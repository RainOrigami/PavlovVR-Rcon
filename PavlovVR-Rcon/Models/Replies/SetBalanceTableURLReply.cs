namespace PavlovVR_Rcon.Models.Replies
{
    public class SetBalanceTableURLReply : BaseReply
    {
        public string GithubURL { get; init; } = string.Empty;
        public bool SetBalanceTableURL { get; init; }
    }
}
