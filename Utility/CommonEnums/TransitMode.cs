using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Utility.CommonEnums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransitMode
    {
        bus, subway, train, tram, rail
    }
}
