using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GoogleMapServices.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnitSystem
    {
        metric, imperial
    }
}
