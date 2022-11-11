namespace PavlovVR_Rcon.Exceptions;

public class CommandFailedException : RconException
{
    public CommandFailedException(PavlovRcon rcon, string command, string[]? parameters, Exception? innerException = null) : base(rcon, "The command could not be executed", innerException)
    {
        this.Command = command;
        this.Parameters = parameters;
    }

    public string Command { get; }
    public string[]? Parameters { get; }
}
