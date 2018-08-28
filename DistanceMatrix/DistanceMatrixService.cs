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

        public  Task< DistanceMatrixResponse> GetDirectionsAsync(DistanceMatrixRequest request)
        {
            if (string.IsNullOrEmpty(request.Key))
            {
                request.Key = _key;
            }
            Task<HttpResponseMessage> resp = _client.GetAsync(baseUrl + request.ToString());
            if (resp.Result.IsSuccessStatusCode)
            {
                string data =  resp.Result.Content.ReadAsStringAsync().Result;

               return Task.FromResult(JsonConvert.DeserializeObject<DistanceMatrixResponse>(data)) ;

            }
            else
            {
                var directionsResponse = new DistanceMatrixResponse { Successfull = false};
                directionsResponse.Status = Matrixstatus.UNKNOWN_ERROR;
                return Task.FromResult(directionsResponse);
            }


        }

        public DistanceMatrixResponse GetDirections(DistanceMatrixRequest request)
        {
          return  GetDirectionsAsync(request).Result;
        }


    }
}
