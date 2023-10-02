using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

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