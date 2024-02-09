# PavlovVR-Rcon
A library to interface with Pavlov VR servers, execute RCON commands and process their replies.

PCVR only, Shack is not supported.

Available on NuGet: https://www.nuget.org/packages/PavlovVR-Rcon/

# Usage

## Connecting

```cs
PavlovRcon rcon = new("host.com", 9100, "password");
await rcon.Connect(CancellationToken.None);
```

If your server resolves an IPv6 through an AAAA record but your Pavlov VR server only binds on IPv4, you can specify an optional forceIpv4 parameter in the constructor to force IPv4:

```cs
PavlovRcon rcon = new("host.com", 9100, "password", true);
```

## Running commands

```cs
ServerInfoReply serverInfo = await new ServerInfoCommand().ExecuteCommand(rcon);
Console.WriteLine(serverInfo.ServerInfo.ServerName);
```

```cs
InspectPlayerReply inspectPlayer = await new InspectPlayerCommand(76561198142010443).ExecuteCommand(rcon);
Console.WriteLine(inspectPlayer.PlayerInfo.Score);
```

```cs
string reply = await rcon.SendTextCommand("CustomCommand", new[] { "parameter1", "parameter2" });
```

You can also create custom reply classes to automatically parse the reply:

```json
{
  "Command": "CustomCommand",
  "CustomStuff": {
    "SomeCustomValue": "Something"
  },
  "Successful": true
}
```

```cs
public class CustomData
{
  public string SomeCustomValue { get; init; } = string.Empty;
}

public class CustomReply : BaseReply
{
  public CustomData CustomStuff { get; init; } = new();
}

CustomReply reply = await rcon.SendCommand<CustomReply>("MyCommand");
Console.WriteLine(reply.CustomStuff.SomeCustomValue);
```

and also use a custom command class:

```cs
public class CustomCommand : BaseCommand<CustomReply>
{
  public CustomCommand(string someParameter) : base("MyCommand")
  {
    this.addParameter(someParameter);
  }
}

CustomReply reply = await new CustomCommand("myParameter").ExecuteCommand(rcon);
```

Note: While the server is switching maps, commands will fail since the server can not process any RCON commands during this time. This will also set `rcon.Connected` to `false`, since the connection status is based on the success of the last executed command. Therefore, if the server becomes offline, `rcon.Connected` may still be `true` but `ExecuteCommand` will throw an exception. In these cases you may simply call `Connect` again until it succeeds.

# Available commands

Except for Help and Disconnect, all commands from http://pavlovwiki.com/index.php/Rcon_Overview_and_Commands are available.

To quote the Pavlov VR wiki:

```
What is important if you are issuing commands using a program at high frequency is that you open one connection and put all of the commands through that open connection with a small (.1 sec is fine) delay. What you don't want to do is open a new connection for each command or shove all of the commands through super fast. First causes performance issues and the second dropped commands.
```

This, again, is a limitation of the server.

# Notes

## Setting the command timeout
After executing a command, the reply will be received. The default timeout for this operation is two seconds. You can change this timeout by setting `rcon.CommandTimeout` to an appropriate value in milliseconds.

## ServerInfo.PlayerCount
Pavlov is... mentally challenged, and reports the RCON client as a player (sometimes, not always). Because of that you may see PlayerCount to be bigger than the actual player count.
It is therefore recommended to instead use RefreshListCommand and count the actual players.

## Exceptions
Connecting and executing commands will throw exceptions if they do not succeed. This includes commands that have been sent to the server but are replied with `"Successful": false`. It is therefore recommended that you try-catch any connection and command execution methods to handle errors like:
- Unable to connect
- Timeout
- Command failed

If any errors occur, the exception will contain inner exceptions until the source exception is reached (for timeouts in commands, for example, you would get CommandFailedException with CommandTimeoutException with OperationCanceledException, or if the Json reply could not be parsed you would get CommandFailedException with UnexpectedRconResponseException with the underlying exception). This way you should be able to pinpoint the error cause in code, to handle the error appropriately.
