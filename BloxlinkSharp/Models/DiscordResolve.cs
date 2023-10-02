using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class DiscordResolve
{
    [JsonProperty("discordIDs")]
    public List<string> DiscordIDs { get; set; } = new();

    [JsonProperty("resolved")]
    public ResolvedDiscord? Resolved { get; set; }
}

public class ResolvedDiscord
{
    [JsonProperty("discord")]
    public Dictionary<string, DiscordUserResolve> Discord { get; set; } = new();
}

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

public class DiscordUserDetails
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("username")]
    public string? Username { get; set; }

    [JsonProperty("avatar")]
    public string? Avatar { get; set; }

    [JsonProperty("discriminator")]
    public string? Discriminator { get; set; }

    [JsonProperty("public_flags")]
    public int PublicFlags { get; set; }

    [JsonProperty("flags")]
    public int Flags { get; set; }

    [JsonProperty("banner")]
    public object? Banner { get; set; }

    [JsonProperty("accent_color")]
    public int AccentColor { get; set; }

    [JsonProperty("global_name")]
    public string? GlobalName { get; set; }

    [JsonProperty("avatar_decoration_data")]
    public object? AvatarDecorationData { get; set; }

    [JsonProperty("banner_color")]
    public string? BannerColor { get; set; }
}