﻿namespace PavlovVR_Rcon.Models.Replies;

public class BaseReply
{
    public bool Successful { get; init; }
    public string Command { get; init; }
    public string? Comment { get; init; }

    public string RawReply { get; internal set; }
}
