namespace PavlovVR_Rcon.Exceptions;

public class CommandTimeoutException : RconException
{
    public CommandTimeoutException(PavlovRcon rcon, Exception? innerException = null) : base(rcon, "The server did not send a response in time", innerException) { }
}
