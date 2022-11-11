namespace PavlovVR_Rcon.Exceptions;

public class UnexpectedRconResponseException : RconException
{
    public UnexpectedRconResponseException(PavlovRcon rcon, string response, Exception? innerException = null) : base(rcon, "An unexpected RCON response has been received", innerException)
    {
        this.Response = response;
    }

    public string Response { get; }
}
