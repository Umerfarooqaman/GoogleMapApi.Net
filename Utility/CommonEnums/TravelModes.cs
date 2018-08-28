using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Utility.CommonEnums
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TravelModes
    {
        driving, walking, bicycling, transit
    }
}
