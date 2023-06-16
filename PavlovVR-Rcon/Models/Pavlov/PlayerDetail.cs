namespace PavlovVR_Rcon.Models.Pavlov;

public class PlayerDetail
{
    public ulong UniqueId { get; init; }
    public string PlayerName { get; init; } = string.Empty;
    public string KDA { get; init; } = string.Empty;
    public int Cash { get; init; }
    public bool Dead { get; init; }
    public int TeamId { get; init; }
    public int Score { get; init; }
    public float Ping { get; init; }
}
