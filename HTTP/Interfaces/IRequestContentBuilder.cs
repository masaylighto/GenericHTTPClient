

using DataKit.Result;

namespace GenericHTTPClient.Interfaces;

public interface IRequestContentBuilder<ContentType> where ContentType : class
{
    /// <summary>
    ///  Specify how the http content will be built from the data passed into the class
    /// </summary>
    Task<Result<HttpContent>> BuildContent(ContentType contentType);
}
