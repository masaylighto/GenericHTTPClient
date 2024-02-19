

using GenericHTTPClient.Interfaces;
using GenericHTTPClient.ResponseDeserializers;

namespace GenericHTTPClient;

public class Request<ReturnType, RequestContent> where ReturnType : class where RequestContent : class
{
    public required string Endpoint { get; set; }
    public IResponseDeserializer<ReturnType> ResponseDeserialize { get; set; } = new JsonResponseDeserializer<ReturnType>();
    public RequestContent? Content { get; set; }
    public IRequestContentBuilder<RequestContent>? HTTPContentBuilder { get; set; }
}
