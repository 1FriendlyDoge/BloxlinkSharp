using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

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