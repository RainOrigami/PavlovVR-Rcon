namespace PavlovVR_Rcon.Exceptions;

public class AuthenticationFailedException : RconException
{
    public AuthenticationFailedException(PavlovRcon rcon) : base(rcon, "Authentication with the server has failed") { }
}
