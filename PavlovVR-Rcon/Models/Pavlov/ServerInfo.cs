namespace PavlovVR_Rcon.Models.Pavlov;

public class ServerInfo
{
    public string MapLabel { get; init; } = string.Empty;
    public string GameMode { get; init; } = string.Empty;
    public string ServerName { get; init; } = string.Empty;
    public bool Teams { get; init; }
    public int? Team0Score { get; init; }
    public int? Team1Score { get; init; }
    public int? Round { get; init; }
    public string RoundState { get; init; } = string.Empty;
    public string PlayerCount { get; init; } = string.Empty;
}
