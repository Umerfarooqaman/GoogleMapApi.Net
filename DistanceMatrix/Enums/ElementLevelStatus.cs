using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DistanceMatrix.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElementLevelStatus
    {
        OK,
        NOT_FOUND,
        ZERO_RESULTS,
        MAX_ROUTE_LENGTH_EXCEEDED
    }
}