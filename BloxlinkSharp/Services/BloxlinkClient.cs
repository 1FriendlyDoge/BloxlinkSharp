using System.Net.Http.Headers;

namespace BloxlinkSharp.Services;

public class BloxlinkClient : HttpClient
{
    public BloxlinkClient(string apiKey, string baseUrl)
    {
        DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);
        BaseAddress = new Uri(baseUrl);
    }
}