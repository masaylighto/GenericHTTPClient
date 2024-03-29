﻿

using GenericHTTPClient.Interfaces;
using System.Net.Http.Headers;

namespace GenericHTTPClient.AuthStrategies;

public class JwtAuthStrategy : IAuthStrategy
{
    public string JwtToken { get; }
    public JwtAuthStrategy(string jwtToken)
    {
        JwtToken = jwtToken;
    }
    public void ApplyAuth(HttpRequestHeaders headers)
    {
        headers.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);
    }
}
