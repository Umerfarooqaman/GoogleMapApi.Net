using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Utility.CommonEnums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Avoidables
    {
        tolls, highways, ferries, indoor
    }
}
