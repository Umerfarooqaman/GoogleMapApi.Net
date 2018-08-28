using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DirectionsApi.Models
{
    public class Polyline
    {

        [JsonProperty("points")]
        public string Points { get; set; }
    }
}
