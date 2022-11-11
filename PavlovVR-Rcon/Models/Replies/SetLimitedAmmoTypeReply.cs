namespace PavlovVR_Rcon.Models.Replies;

public class SetLimitedAmmoTypeReply : BaseReply
{
    public bool SetLimitedAmmoType { get; init; }
    public int LimitedAmmoType { get; init; }
}
