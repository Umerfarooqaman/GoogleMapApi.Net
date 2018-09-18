using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
 

namespace GoogleMapServices.Models
{
    public class Leg
    {

        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("duration_in_traffic")]
        public Duration DurationInTraffic { get; set; }

        [JsonProperty("end_address")]
        public string EndAddress { get; set; }

        [JsonProperty("end_location")]
        public NamedLatLongPair EndLocation { get; set; }

        [JsonProperty("start_address")]
        public string StartAddress { get; set; }

        [JsonProperty("start_location")]
        public NamedLatLongPair StartLocation { get; set; }

        [JsonProperty("steps")]
        public IList<Step> Steps { get; set; }

        [JsonProperty("arrival_time ")]
        public Time ArrivalTime { get; set; }

        [JsonProperty("departure_time ")]
        public Time DepartureTime { get; set; }

        [JsonProperty("traffic_speed_entry")]
        public IList<object> TrafficSpeedEntry { get; set; }

        [JsonProperty("via_waypoint")]
        public IList<string> ViaWaypoint { get; set; }
    }

}
