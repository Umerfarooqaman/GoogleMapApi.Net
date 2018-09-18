using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
    public class NamedLatLongPair : LatLongPair
    {

        [JsonProperty("lat")]
        public new double Latitude { get; set; }

        [JsonProperty("lng")]
        public new double Longitude { get; set; }
    }
}
