using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DirectionsApi.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeoCoderStatus
    {
        OK, ZERO_RESULTS
    }
}
