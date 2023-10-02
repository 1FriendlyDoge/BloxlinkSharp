using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class RobloxResolve
{
    [JsonProperty("robloxID")]
    public string? RobloxID { get; private set; }
    
    [JsonProperty("resolved")]
    public Resolved? Resolved { get; private set; }
}

public class Resolved
{
    [JsonProperty("discord")]
    public Discord? Discord { get; private set; }

    [JsonProperty("roblox")]
    public Roblox? Roblox { get; private set; }
}

public class Discord
{
    [JsonProperty("avatar")]
    public string? Avatar { get; private set; }

    [JsonProperty("communication_disabled_until")]
    public object? CommunicationDisabledUntil { get; private set; }

    [JsonProperty("flags")]
    public int Flags { get; private set; }

    [JsonProperty("joined_at")]
    public DateTime JoinedAt { get; private set; }

    [JsonProperty("nick")]
    public string? Nick { get; private set; }

    [JsonProperty("pending")]
    public bool Pending { get; private set; }

    [JsonProperty("premium_since")]
    public object? PremiumSince { get; private set; }

    [JsonProperty("roles")]
    public List<string> Roles { get; private set; } = new();

    [JsonProperty("unusual_dm_activity_until")]
    public object? UnusualDmActivityUntil { get; private set; }

    [JsonProperty("user")]
    public DiscordUser? DiscordUser { get; private set; }

    [JsonProperty("mute")]
    public bool Mute { get; private set; }

    [JsonProperty("deaf")]
    public bool Deaf { get; private set; }
}

public class DiscordUser
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
    public string? Banner { get; private set; }

    [JsonProperty("accent_color")]
    public int AccentColor { get; private set; }

    [JsonProperty("global_name")]
    public string? GlobalName { get; private set; }

    [JsonProperty("avatar_decoration_data")]
    public object? AvatarDecorationData { get; private set; }

    [JsonProperty("banner_color")]
    public string? BannerColor { get; private set; }
}

public class Roblox
{
    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("id")]
    public int Id { get; private set; }

    [JsonProperty("displayName")]
    public string? DisplayName { get; private set; }

    [JsonProperty("description")]
    public string? Description { get; private set; }

    [JsonProperty("isBanned")]
    public bool IsBanned { get; private set; }

    [JsonProperty("created")]
    public DateTime Created { get; private set; }

    [JsonProperty("badges")]
    public List<Badge> Badges { get; private set; } = new();

    [JsonProperty("profileLink")]
    public string? ProfileLink { get; private set; }

    [JsonProperty("presence")]
    public object? Presence { get; private set; }

    [JsonProperty("groups")]
    public List<Group> Groups { get; private set; } = new();

    [JsonProperty("avatar")]
    public Avatar? Avatar { get; private set; }

    [JsonProperty("rap")]
    public object? Rap { get; private set; }

    [JsonProperty("value")]
    public object? Value { get; private set; }

    [JsonProperty("placeVisits")]
    public object? PlaceVisits { get; private set; }

    [JsonProperty("hasDisplayName")]
    public bool HasDisplayName { get; private set; }

    [JsonProperty("externalAppDisplayName")]
    public object? ExternalAppDisplayName { get; private set; }

    [JsonProperty("hasVerifiedBadge")]
    public bool HasVerifiedBadge { get; private set; }

    [JsonProperty("groupsv2")]
    public Dictionary<string, GroupV2> Groupsv2 { get; private set; } = new();
}

public class Badge
{
    [JsonProperty("ImageUri")]
    public string? ImageUri { get; private set; }

    [JsonProperty("Name")]
    public string? Name { get; private set; }
}

public class Group
{
    [JsonProperty("group")]
    public GroupInfo? GroupInfo { get; private set; }

    [JsonProperty("role")]
    public Role? Role { get; private set; }
}

public class GroupInfo
{
    [JsonProperty("id")]
    public int Id { get; private set; }

    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("memberCount")]
    public int MemberCount { get; private set; }

    [JsonProperty("hasVerifiedBadge")]
    public bool HasVerifiedBadge { get; private set; }
}

public class Role
{
    [JsonProperty("id")]
    public int Id { get; private set; }

    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("rank")]
    public int Rank { get; private set; }
}

public class Avatar
{
    [JsonProperty("bustThumbnail")]
    public string? BustThumbnail { get; private set; }

    [JsonProperty("headshotThumbnail")]
    public string? HeadshotThumbnail { get; private set; }

    [JsonProperty("fullBody")]
    public string? FullBody { get; private set; }
}

public class GroupV2
{
    [JsonProperty("group")]
    public GroupInfo? GroupInfo { get; private set; }

    [JsonProperty("role")]
    public Role? Role { get; private set; }
}