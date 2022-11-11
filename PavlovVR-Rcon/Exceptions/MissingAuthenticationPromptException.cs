namespace PavlovVR_Rcon.Exceptions;

public class MissingAuthenticationPromptException : RconException
{
    public MissingAuthenticationPromptException(PavlovRcon rcon) : base(rcon, "The server did not send an authentication prompt after connecting.") { }
}
