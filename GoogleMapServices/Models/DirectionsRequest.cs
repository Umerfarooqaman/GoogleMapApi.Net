using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleMapServices.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
 
 
using Avoidables = GoogleMapServices.Enums.Avoidables;

namespace GoogleMapServices.Models
{
    public class DirectionsRequest
    {

        public LocationParameter Origin { get; set; }

        public LocationParameter Destination { get; set; }

        public string Key { get; set; }


        public TravelModes? TravelMode { get; set; }

        public List<WayPointParameter> WayPoints { get; set; }


        public bool Alternatives { get; set; } = false;


        public List<Avoidables> Avoid { get; set; }


        public string Language { get; set; }


        public UnitSystem Units { get; set; }

        public string Region { get; set; }

        public DateTime? ArrivalTime { get; set; }

        public DateTime? DepartureTime { get; set; }

        public TrafficModel? TrafficModel { get; set; }

        public List<TransitMode> TransitMode { get; set; }

        public List<TransitRoutingPreference> TransitRoutingPreferences { get; set; }


        public override string ToString()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            //adding required parrameters
            if (Origin != null) parameters.Add("origin", Origin.ToString());

            if (Destination != null) parameters.Add("destination", value: Destination.ToString());

          if(!string.IsNullOrEmpty(Key))  parameters.Add("key", Key);


            //adding optional parametres
            if (TravelMode != null) parameters.Add("mode", TravelMode.Value.ToString());

            if (WayPoints != null && WayPoints.Count > 0) parameters.Add("waypoints", string.Join("|", WayPoints.Distinct().Select(d => d.ToString())));

            if (Alternatives) parameters.Add("alternatives", Alternatives.ToString());

            if (Avoid != null) parameters.Add("avoid", string.Join("|", Avoid.Distinct().Select(d => d.ToString())));

            if (string.IsNullOrEmpty(Language)) parameters.Add("language", Language);

            if (Units is UnitSystem.imperial) parameters.Add("units", Units.ToString());

            if (string.IsNullOrEmpty(Region)) parameters.Add("region", Region);

            if (ArrivalTime != null)
                parameters.Add("arrival_time",
                    ArrivalTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc) != null
                        ? (ArrivalTime.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Seconds.ToString()
                        : null);

            if (DepartureTime != null)
                parameters.Add("departure_time",
                    DepartureTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc) != null
                        ? (DepartureTime.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Seconds.ToString()
                        : null);

            if (TrafficModel != null) parameters.Add("traffic_model", TrafficModel.ToString());

            if (TransitMode != null)
                parameters.Add("transit_mode", string.Join("|", TransitMode.Distinct().Select(d => d.ToString())));

            if (TransitRoutingPreferences != null)
                parameters.Add("transit_routing_preference", TransitRoutingPreferences.ToString());

            return string.Join("&", parameters.Select(d => d.Key + "=" + d.Value));
        }
    }
}
