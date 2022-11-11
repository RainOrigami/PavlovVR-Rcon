namespace PavlovVR_Rcon.Models.Replies;

public abstract class BaseReply
{
    public bool Successful { get; init; }
    public string Command { get; init; }

    public string RawReply { get; internal set; }
}
