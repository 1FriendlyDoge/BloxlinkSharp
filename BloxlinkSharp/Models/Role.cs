using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class Role
{
    [JsonProperty("id")]
    public int Id { get; private set; }

    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("rank")]
    public int Rank { get; private set; }
}