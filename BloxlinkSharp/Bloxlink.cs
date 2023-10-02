using BloxlinkSharp.Exceptions;

namespace BloxlinkSharp;

public class Bloxlink
{
    private string? _apiKey;
    private string _baseUrl = "https://api.blox.link/v4/";

    public Bloxlink()
    {
        // This should only be used for env initialization!
    }

    public Bloxlink(string apiKey)
    {
        _apiKey = apiKey;
    }
    
    public Bloxlink UseAuthEnvironment()
    {
        string? authEnvValue = Environment.GetEnvironmentVariable("BloxlinkAuth");
        
        _apiKey = authEnvValue ?? throw new EnvironmentVariableNull("BloxlinkAuth");
        return this;
    }
}