namespace PavlovVR_Rcon.Exceptions;

public class RconException : Exception
{
    public RconException(PavlovRcon rcon, string? message = null, Exception? innerException = null) : base(message ?? "An unknown RCON exception has occurred", innerException)
    {
        this.Rcon = rcon;
    }

    public PavlovRcon Rcon { get; }
}
