using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
 

namespace GoogleMapServices.Models
{
    public class Step
    {
        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("end_location")]
        public NamedLatLongPair EndLocation { get; set; }

        [JsonProperty("html_instructions")]
        public string HtmlInstructions { get; set; }

        [JsonProperty("polyline")]
        public Polyline Polyline { get; set; }

        [JsonProperty("start_location")]
        public NamedLatLongPair StartLocation { get; set; }

        [JsonProperty("travel_mode")]
        public string TravelMode { get; set; }

        [JsonProperty("maneuver")]
        public string Maneuver { get; set; }

        [JsonProperty("transit_details ")]
        public TransitDetail TransitDetail { get; set; }
    }
}
