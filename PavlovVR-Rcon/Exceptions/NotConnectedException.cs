namespace PavlovVR_Rcon.Exceptions;

public class NotConnectedException : RconException
{
    public NotConnectedException(PavlovRcon rcon) : base(rcon, "There is no RCON connection") { }
}
