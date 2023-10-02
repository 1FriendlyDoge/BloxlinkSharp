using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class DiscordUserResolve
{
    [JsonProperty("avatar")]
    public object? Avatar { get; private set; }

    [JsonProperty("communication_disabled_until")]
    public object? CommunicationDisabledUntil { get; private set; }

    [JsonProperty("flags")]
    public int Flags { get; private set; }

    [JsonProperty("joined_at")]
    public DateTime JoinedAt { get; private set; }

    [JsonProperty("nick")]
    public object? Nick { get; private set; }

    [JsonProperty("pending")]
    public bool Pending { get; private set; }

    [JsonProperty("premium_since")]
    public object? PremiumSince { get; private set; }

    [JsonProperty("roles")]
    public List<string> Roles { get; private set; } = new();

    [JsonProperty("unusual_dm_activity_until")]
    public object? UnusualDmActivityUntil { get; private set; }

    [JsonProperty("user")]
    public DiscordUserDetails? User { get; private set; }

    [JsonProperty("mute")]
    public bool Mute { get; private set; }

    [JsonProperty("deaf")]
    public bool Deaf { get; private set; }
}