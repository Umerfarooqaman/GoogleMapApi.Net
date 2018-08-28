using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.CommonEnums;
using Utility.CommonModels;

namespace DistanceMatrix.Models
{
    public class DistanceMatrixRequest
    {
       

        public List<LocationParameter> Origins;
        public List<LocationParameter> Destinations;


        
        public TravelModes? TravelMode { get; set; }

        /// <summary>
        /// <returns></returns>
        /// </summary>
        public string Language { get; set; }


        public string Region { get; set; }
        
        public List<Avoidables> Avoid { get; set; }

        
        public UnitSystem? Units { get; set; }


        public DateTime? ArrivalTime { get; set; }

        public DateTime? DepartureTime { get; set; }

        
        public TrafficModel? TrafficModel { get; set; }

        
        public List<TransitMode> TransitMode { get; set; }

        
        public TransitRoutingPreference? TransitRoutingPreference { get; set; }



        public override string ToString()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            //adding required parrameters
            if (Origins != null) parameters.Add("origins", string.Join("|", Origins.Select(d=>d.ToString())));

            if (Destinations != null) parameters.Add("destinations", string.Join("|", Destinations.Select(d => d.ToString())));

            if (!string.IsNullOrEmpty(Key)) parameters.Add("key", Key);


            //adding optional parametres
            if (TravelMode != null) parameters.Add("mode", TravelMode.Value.ToString());

          
          
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

            if (TransitRoutingPreference != null)
                parameters.Add("transit_routing_preference", TransitRoutingPreference.ToString());

            return string.Join("&", parameters.Select(d => d.Key + "=" + d.Value));
        }

        public string Key { get; set; }

       
    }
}
