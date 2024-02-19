using DataKit.Result;
using GenericHTTPClient.Interfaces;
using System.Text.Json;

namespace GenericHTTPClient.ResponseDeserializers;

public class JsonResponseDeserializer<ReturnType> : IResponseDeserializer<ReturnType>
{
    public async Task<Result<ReturnType>> Deserialize(HttpResponseMessage httpResponseMessage)
    {
        try
        {
            var result = await JsonSerializer.DeserializeAsync<ReturnType>(httpResponseMessage.Content.ReadAsStream());
            return result is not null ? result : new NullReferenceException("Empty json response after Deserializing");
        }
        catch (Exception ex)
        {
            return ex;
        }
    }
}
