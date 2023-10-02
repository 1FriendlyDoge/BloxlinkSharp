using System.Net.Http.Headers;
using BloxlinkSharp.Exceptions;
using BloxlinkSharp.Models;
using BloxlinkSharp.Services;

namespace BloxlinkSharp;

public class Bloxlink
{
    private string? _apiKey;
    private string _baseUrl = "https://api.blox.link/v4/";
    private BloxlinkClient? _client;


    // Constructors
    
    public Bloxlink()
    {
        // This should only be used for env initialization!
    }

    public Bloxlink(string apiKey, string baseUrl = ConstantValues.DefaultBaseURL)
    {
        _apiKey = apiKey;
        _baseUrl = baseUrl;
    }
    
    private string HandledEnvironmentGet(string field)
    {
        string? value = Environment.GetEnvironmentVariable(field);
        return value ?? throw new EnvironmentVariableNull(field);
    }
    
    public Bloxlink UseBaseUrlEnvironment()
    {
        _baseUrl = HandledEnvironmentGet("BloxlinkBaseURL");
        return this;
    }
    
    public Bloxlink UseAuthEnvironment()
    {
        _apiKey = HandledEnvironmentGet("BloxlinkAuth");
        return this;
    }
    
    public void UpdateAuth(string apiKey)
    {
        _apiKey = apiKey;
        if (_client != null)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);
        }
    }
    
    public Bloxlink Build()
    {
        _client = new BloxlinkClient(_apiKey ?? throw new EnvironmentVariableNull("BloxlinkAuth"), _baseUrl);
        return this;
    }
    
    
    // Methods
    
    public async Task<BloxlinkResponse<RobloxResolve>> DiscordToRoblox(long serverID, long userID)
    {
        if (_client == null)
        {
            throw new BloxlinkClientNotBuilt();
        }

        return BloxlinkResponse<RobloxResolve>.FromHttpResponse(
            await _client.GetAsync($"public/guilds/{serverID}/discord-to-roblox/{userID}"));
    }
}