using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class Group
{
    [JsonProperty("group")]
    public GroupInfo? GroupInfo { get; private set; }

    [JsonProperty("role")]
    public Role? Role { get; private set; }
}