using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class DiscordUserDetails
{
    [JsonProperty("id")]
    public string? Id { get; private set; }

    [JsonProperty("username")]
    public string? Username { get; private set; }

    [JsonProperty("avatar")]
    public string? Avatar { get; private set; }

    [JsonProperty("discriminator")]
    public string? Discriminator { get; private set; }

    [JsonProperty("public_flags")]
    public int PublicFlags { get; private set; }

    [JsonProperty("flags")]
    public int Flags { get; private set; }

    [JsonProperty("banner")]
    public object? Banner { get; private set; }

    [JsonProperty("accent_color")]
    public int AccentColor { get; private set; }

    [JsonProperty("global_name")]
    public string? GlobalName { get; private set; }

    [JsonProperty("avatar_decoration_data")]
    public object? AvatarDecorationData { get; private set; }

    [JsonProperty("banner_color")]
    public string? BannerColor { get; private set; }
}