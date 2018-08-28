using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DirectionsApi.Models;

namespace DirectionsApi
{
    public class DirectionsExtentions
    {
        /// <summary>
        /// return DirectionsResponce using Direction service as a singleton 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DirectionsResponse GetDirections(DirectionsRequest request)
        {
           return DirectionsService.GetSingletonInstance().GetDirections(request);
        }
        /// <summary>
        /// return asynchronous  DirectionsResponce using Direction service as a singleton 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Task< DirectionsResponse> GetDirectionsAsync(DirectionsRequest request)
        {
            return DirectionsService.GetSingletonInstance().GetDirectionsAsync(request);
        }
    }
}
