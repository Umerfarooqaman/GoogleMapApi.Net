using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
    public class Bounds
    {

        [JsonProperty("northeast")]
        public Coordinates Northeast { get; set; }

        [JsonProperty("southwest")]
        public Coordinates Southwest { get; set; }
    }
}
