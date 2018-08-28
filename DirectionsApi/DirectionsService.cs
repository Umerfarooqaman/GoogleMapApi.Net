using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DirectionsApi.Models;
using Utility;
using static Newtonsoft.Json.JsonConvert;

namespace DirectionsApi
{
    public sealed class DirectionsService : InstanceManager<DirectionsService>
    {
        static readonly string baseUrl = "https://maps.googleapis.com/maps/api/directions/json?";

        private readonly HttpClient _client = new HttpClient();

        public  Task< DirectionsResponse> GetDirectionsAsync(DirectionsRequest request)
        {
            Task<HttpResponseMessage> resp = _client.GetAsync(baseUrl + request.ToString());
            if (resp.Result.IsSuccessStatusCode)
            {
                string data =  resp.Result.Content.ReadAsStringAsync().Result;

               return Task.FromResult(DeserializeObject<DirectionsResponse>(data)) ;

            }
            else
            {
                var directionsResponse = new DirectionsResponse {Successfull = false};

                return Task.FromResult(directionsResponse);
            }


        }

        public DirectionsResponse GetDirections(DirectionsRequest request)
        {
          return  GetDirectionsAsync(request).Result;
        }


    }
}
