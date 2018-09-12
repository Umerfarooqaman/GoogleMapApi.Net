using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using GoogleMapServices.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

 
 
using Avoidables = GoogleMapServices.Enums.Avoidables;

namespace GoogleMapServices.Models
{
    public class DirectionsRequest
    {
        private string ArrivalTime;
        private string DepartureTime;
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

        [JsonIgnore]
        public DateTime? _ArrivalTime
        {
            get { return ArrivalTime.ParseFromWeb() ;}
            set { ArrivalTime = value.FormatAsWeb(); }
        }

        [JsonIgnore]
        public DateTime? _DepartureTime
        {
            get { return DepartureTime.ParseFromWeb(); }
            set { DepartureTime = value.FormatAsWeb(); }
        }

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

            if (!string.IsNullOrEmpty(Language)) parameters.Add("language", Language);

            if (Units is UnitSystem.imperial) parameters.Add("units", Units.ToString());

            if (!string.IsNullOrEmpty(Region)) parameters.Add("region", Region);

            if (!string.IsNullOrEmpty(ArrivalTime))
                parameters.Add("arrival_time",
                    _ArrivalTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc) != null
                        ? Math.Floor((_ArrivalTime.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds).ToString(CultureInfo.InvariantCulture)
                        : null);

            if (!string.IsNullOrEmpty(DepartureTime))
                parameters.Add("departure_time",
                    _DepartureTime  != null
                        ?Math.Floor( (_DepartureTime.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                        .TotalSeconds).ToString(CultureInfo.InvariantCulture)
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
