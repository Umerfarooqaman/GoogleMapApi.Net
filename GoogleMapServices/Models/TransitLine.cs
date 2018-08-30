using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
    public class TransitLine
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("agencies")]
        public List< TransitAgency> Agencies { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("text_color")]
        public string TextColor { get; set; }

        [JsonProperty("vehicle")]
        public TransitVehicle Vehicle { get; set; }

    }
}
