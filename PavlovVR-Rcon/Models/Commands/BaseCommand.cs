using PavlovVR_Rcon.Models.Replies;

namespace PavlovVR_Rcon.Models.Commands;

public abstract class BaseCommand<T> where T : BaseReply
{
    private readonly List<string> parameters = new();

    public BaseCommand(string command)
    {
        this.Command = command;
    }

    public string Command { get; init; }
    public IReadOnlyList<string> Parameters => this.parameters;

    protected void addParameter(string parameter)
    {
        this.parameters.Add(parameter);
    }

    public async Task<T> ExecuteCommand(PavlovRcon connection)
    {
        return await connection.SendCommand<T>(this.Command, this.parameters.ToArray());
    }
}
