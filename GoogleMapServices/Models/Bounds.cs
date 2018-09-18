using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
    public class Bounds
    {

        [JsonProperty("northeast")]
        public NamedLatLongPair Northeast { get; set; }

        [JsonProperty("southwest")]
        public NamedLatLongPair Southwest { get; set; }
    }
}
