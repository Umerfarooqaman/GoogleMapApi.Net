using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DirectionsApi.Models
{
    public class Coordinates : Utility.CommonModels.LatLongPair
    {

        [JsonProperty("lat")]
        public new double Latitude { get; set; }

        [JsonProperty("lng")]
        public new double Longitude { get; set; }
    }
}
