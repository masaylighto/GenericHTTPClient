﻿
#pragma warning disable S3925 // "ISerializable" should be implemented correctly. no need to implement ISerializable as no new data field is added to this class
using System.Runtime.Serialization;
namespace DataKit.Exceptions;

public class NoResponseException : Exception

{
    public NoResponseException() : base()
    {
    }

    public NoResponseException(string? message) : base(message)
    {
    }

    public NoResponseException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        // Deserialize fields here, if you ever add any.
    }
}
