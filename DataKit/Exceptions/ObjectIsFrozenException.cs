
using System.Runtime.Serialization;

namespace DataKit.Exceptions;

public class ObjectIsFrozenException : Exception
{
    public ObjectIsFrozenException()
    {
    }

    protected ObjectIsFrozenException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
