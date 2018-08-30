using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GoogleMapServices.Enums
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TravelModes
    {
        driving, walking, bicycling, transit
    }
}
