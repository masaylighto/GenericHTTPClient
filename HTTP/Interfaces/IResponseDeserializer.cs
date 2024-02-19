
using DataKit.Result;

namespace GenericHTTPClient.Interfaces;

public interface IResponseDeserializer<ReturnType>
{  /// <summary>
   ///  Specify how the http response will be Deserialize from the data received. 
   /// </summary>
    Task<Result<ReturnType>> Deserialize(HttpResponseMessage httpResponseMessage);
}
