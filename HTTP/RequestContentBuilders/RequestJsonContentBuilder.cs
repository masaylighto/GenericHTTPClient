﻿#pragma warning disable CS1998 // Async method lacks 'await'. no need to use async here its only add in the interface to be compatible with code that require it
using DataKit.Result;
using GenericHTTPClient.Interfaces;
using System.Text.Json;

namespace GenericHTTPClient.RequestContentBuilders
{
    public class RequestJsonContentBuilder<ContentType> : IRequestContentBuilder<ContentType> where ContentType : class
    {

        public async Task<Result<HttpContent>> BuildContent(ContentType contentType)
        {
            try
            {

                var serializedData = JsonSerializer.Serialize(contentType);
                if (serializedData is null)
                {
                    return new NullReferenceException("Empty json request content after Serializing");
                }
                return new StringContent(serializedData, new System.Net.Http.Headers.MediaTypeHeaderValue("Application/Json"));
            }
            catch (Exception ex)
            {

                return ex;
            }
        }
    }
}
