using System.Net;
using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class BloxlinkResponse<T> where T : class
{
    public HttpStatusCode StatusCode { get; private set; }
    public T? Data { get; private set; }
    
    public BloxlinkResponse(HttpStatusCode statusCode, T? data)
    {
        StatusCode = statusCode;
        Data = data;
    }
    
    public bool IsSuccess()
    {
        return (int) StatusCode >= 200 && (int) StatusCode < 300;
    }
    
    protected internal static BloxlinkResponse<T> FromHttpResponse(HttpResponseMessage response)
    {
        return new BloxlinkResponse<T>(response.StatusCode, response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result) : null);
    }
}