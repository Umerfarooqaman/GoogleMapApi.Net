using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
 
using GoogleMapServices.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
 

namespace GoogleMapServices.Models
{
    public class DirectionsResponse
    {
        [IgnoreDataMember]
        public bool Successfull { get; set; } = true;

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("available_travel_modes")]
        public List<TravelModes> AvailableTravelModes { get; set; }

        [JsonProperty("geocoded_waypoints")]
        public IList<GeocodedWaypoint> GeocodedWaypoints { get; set; }

        [JsonProperty("routes")]
        public IList<Route> Routes { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public DirectionsStatus Status { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
