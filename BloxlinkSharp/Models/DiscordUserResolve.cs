using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class DiscordUserResolve
{
    [JsonProperty("avatar")]
    public object? Avatar { get; set; }

    [JsonProperty("communication_disabled_until")]
    public object? CommunicationDisabledUntil { get; set; }

    [JsonProperty("flags")]
    public int Flags { get; set; }

    [JsonProperty("joined_at")]
    public DateTime JoinedAt { get; set; }

    [JsonProperty("nick")]
    public object? Nick { get; set; }

    [JsonProperty("pending")]
    public bool Pending { get; set; }

    [JsonProperty("premium_since")]
    public object? PremiumSince { get; set; }

    [JsonProperty("roles")]
    public List<string> Roles { get; set; } = new();

    [JsonProperty("unusual_dm_activity_until")]
    public object? UnusualDmActivityUntil { get; set; }

    [JsonProperty("user")]
    public DiscordUserDetails? User { get; set; }

    [JsonProperty("mute")]
    public bool Mute { get; set; }

    [JsonProperty("deaf")]
    public bool Deaf { get; set; }
}