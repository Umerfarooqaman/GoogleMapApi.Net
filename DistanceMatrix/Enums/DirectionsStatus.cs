using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DistanceMatrix.Enums
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Matrixstatus
    {
        OK,
        MAX_ELEMENTS_EXCEEDED,
        INVALID_REQUEST,
        OVER_DAILY_LIMIT,
        OVER_QUERY_LIMIT,
        REQUEST_DENIED,
        UNKNOWN_ERROR


    }
}
