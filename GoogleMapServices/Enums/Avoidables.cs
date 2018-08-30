using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GoogleMapServices.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Avoidables
    {
        tolls, highways, ferries, indoor
    }
}
