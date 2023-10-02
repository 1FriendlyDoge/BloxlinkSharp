using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

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