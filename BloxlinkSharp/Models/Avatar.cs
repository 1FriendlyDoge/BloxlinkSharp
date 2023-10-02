using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class Avatar
{
    [JsonProperty("bustThumbnail")]
    public string? BustThumbnail { get; private set; }

    [JsonProperty("headshotThumbnail")]
    public string? HeadshotThumbnail { get; private set; }

    [JsonProperty("fullBody")]
    public string? FullBody { get; private set; }
}