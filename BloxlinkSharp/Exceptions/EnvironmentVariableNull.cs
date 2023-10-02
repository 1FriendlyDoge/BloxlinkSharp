namespace BloxlinkSharp.Exceptions;

public class EnvironmentVariableNull : Exception
{
    public EnvironmentVariableNull(string variableName) : base($"Environment variable {variableName} is null.") { }
    
    public EnvironmentVariableNull(string variableName, Exception inner) : base($"Environment variable {variableName} is null.", inner) { }
    
    public EnvironmentVariableNull(string variableName, string message) : base($"Environment variable {variableName} is null. {message}") { }
    
    public EnvironmentVariableNull(string variableName, string message, Exception inner) : base($"Environment variable {variableName} is null. {message}", inner) { }
}