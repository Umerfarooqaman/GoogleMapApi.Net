using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GoogleMapServices.Enums;
using GoogleMapServices.Models;
using static Newtonsoft.Json.JsonConvert;

namespace GoogleMapServices
{
    public sealed class DirectionsService : InstanceManager<DirectionsService>, IDirectionsService
    {
        static readonly string baseUrl = "https://maps.googleapis.com/maps/api/directions/json?";

        private readonly HttpClient _client = new HttpClient();
        private string _key;

        /// <inheritdoc />
        public string Key
        {
            set => _key = value;
        }

        /// <inheritdoc />
        public async Task< DirectionsResponse> GetDirectionsAsync(DirectionsRequest request)
        {
            return GetDirections(request);


        }
        /// <inheritdoc />
        public DirectionsResponse GetDirections(DirectionsRequest request)
        {

            if (string.IsNullOrEmpty(request.Key))
            {
                request.Key = !string.IsNullOrEmpty(_key) ? _key : GoogleMapCredentials.Key;
            }
            Task<HttpResponseMessage> resp = _client.GetAsync(baseUrl + request.ToString());
            if (resp.Result.IsSuccessStatusCode)
            {
                string data = resp.Result.Content.ReadAsStringAsync().Result;

                return DeserializeObject<DirectionsResponse>(data);

            }
            else
            {
                var directionsResponse = new DirectionsResponse { Successfull = false };
                directionsResponse.Status = DirectionsStatus.UNKNOWN_ERROR;
                return directionsResponse;
            }
        }


    }
}
