using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DirectionsApi.Models
{
    public class Time
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("time_zone ")]
        public string TimeZone { get; set; }



    }
}
