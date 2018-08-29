using System.Collections;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DistanceMatrix.Enums;
using DistanceMatrix.Models;
using Newtonsoft.Json;
using Utility;

namespace DistanceMatrix
{
    public sealed class DistanceMatrixService : InstanceManager<DistanceMatrixService>, IDistanceMatrixService
    {
         static readonly string baseUrl = "https://maps.googleapis.com/maps/api/distancematrix/json?";

        private readonly HttpClient _client = new HttpClient();
        private string _key;

        public string Key
        {
            set => _key = value;
        }

        public   Task< DistanceMatrixResponse> GetDistanceMatrixAsync(DistanceMatrixRequest request)
        {
            if (string.IsNullOrEmpty(request.Key))
            {
                request.Key = _key;
            }

            request.Origins = request.Origins.GroupBy(d => d.ToString()).Select(g => g.First()).ToList();
            request.Destinations = request.Destinations.GroupBy(d=>d.ToString()).Select(g=>g.First()).ToList();
            var resp = _client.GetAsync(baseUrl + request.ToString());
            if (resp.Result.IsSuccessStatusCode)
            {
                string data =  resp.Result.Content.ReadAsStringAsync().Result;

                var distanceMatrixResponse = JsonConvert.DeserializeObject<DistanceMatrixResponse>(data);

                for (int o = 0; o < request.Origins.Count; o++)
                {
                    for (int d = 0; d < request.Destinations.Count; d++)
                    {
                        var distanceMatrixLookup = new DistanceMatrixLookup(request.Origins[o], request.Destinations[d],
                            distanceMatrixResponse.OriginAddresses[o], distanceMatrixResponse.DestinationAddresses[d],
                            distanceMatrixResponse.Rows[o].Elements[d]);

                        distanceMatrixResponse.LookUp.Add(distanceMatrixLookup);
                    }
                }

                return Task.FromResult(distanceMatrixResponse) ;

            }
            else
            {
                var directionsResponse = new DistanceMatrixResponse
                {
                    Successfull = false,
                    Status = Matrixstatus.UNKNOWN_ERROR
                };
                return Task.FromResult(directionsResponse);
            }


        }

        public DistanceMatrixResponse GetDistanceMatrix(DistanceMatrixRequest request)
        {
          return GetDistanceMatrixAsync(request).Result;
        }


    }
}
