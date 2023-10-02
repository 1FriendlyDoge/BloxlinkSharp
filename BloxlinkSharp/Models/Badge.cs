using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class Badge
{
    [JsonProperty("ImageUri")]
    public string? ImageUri { get; private set; }

    [JsonProperty("Name")]
    public string? Name { get; private set; }
}