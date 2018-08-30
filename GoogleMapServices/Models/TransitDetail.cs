using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GoogleMapServices.Models
{
   public class TransitDetail
    {

        [JsonProperty("arrival_stop")]
        public Stop ArrivalStop { get; set; }

        [JsonProperty("departure_stop")]
        public Stop DepartureStop { get; set; }

        [JsonProperty("arrival_time")]
        public Time ArrivalTime { get; set; }
        [JsonProperty("departure_time")]
        public Time DepartureTime { get; set; }
        [JsonProperty("headsign")]
        public string HeadSign { get; set; }

        [JsonProperty("headway")]
        public int HeadWay  { get; set; }

        [JsonProperty("num_stops")]
        public int StopsCount { get; set; }

        [JsonProperty("line")]
        public TransitLine Line { get; set; }

    }
}
