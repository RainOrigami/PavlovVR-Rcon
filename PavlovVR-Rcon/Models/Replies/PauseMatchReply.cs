namespace PavlovVR_Rcon.Models.Replies;

public class PauseMatchReply : BaseReply
{
    public int PauseTime { get; init; }
    public bool PauseMatch { get; init; }
}
