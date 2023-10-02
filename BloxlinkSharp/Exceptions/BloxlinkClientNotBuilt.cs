namespace BloxlinkSharp.Exceptions;

public class BloxlinkClientNotBuilt : Exception
{
    public BloxlinkClientNotBuilt() : base("The .Build() method was not called.") { }
    
    public BloxlinkClientNotBuilt(Exception inner) : base("The .Build() method was not called..", inner) { }
}