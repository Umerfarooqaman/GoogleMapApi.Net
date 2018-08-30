using System;
using System.Collections.Generic;
using System.Text;
using GoogleMapServices.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace GoogleMapServices.Models
{
   public class TransitVehicle
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public TransitVehicleType Type { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("local_icon")]
        public string LocalIcon { get; set; }

    }
}
