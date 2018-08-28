using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DirectionsApi.Models
{
    public class Route
    {

        [JsonProperty("bounds")]
        public Coordinates Bounds { get; set; }

        [JsonProperty("copyrights")]
        public string Copyrights { get; set; }

        [JsonProperty("legs")]
        public IList<Leg> Legs { get; set; }

        [JsonProperty("overview_polyline")]
        public Polyline OverviewPolyline { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("warnings")]
        public IList<object> Warnings { get; set; }

        [JsonProperty("waypoint_order")]
        public IList<int> WaypointOrder { get; set; }
    }
}
