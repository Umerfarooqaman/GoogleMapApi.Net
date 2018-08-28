using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Utility.CommonEnums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrafficModel
    {
        best_guess, pessimistic, optimistic
    }
}
