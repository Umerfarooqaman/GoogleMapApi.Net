using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DirectionsApi.Models
{
    public class Fare
    {

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
