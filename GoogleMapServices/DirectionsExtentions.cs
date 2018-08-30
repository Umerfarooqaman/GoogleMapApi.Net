using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GoogleMapServices.Models;

namespace GoogleMapServices
{
    public static class DirectionsExtentions
    {
        /// <summary>
        /// return DirectionsResponce using Direction service as a singleton 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DirectionsResponse GetDirections(this DirectionsRequest request)
        {
           return DirectionsService.GetSingletonInstance().GetDirections(request);
        }
        /// <summary>
        /// return asynchronous  DirectionsResponce using Direction service as a singleton 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Task< DirectionsResponse> GetDirectionsAsync(this DirectionsRequest request)
        {
            return DirectionsService.GetSingletonInstance().GetDirectionsAsync(request);
        }
    }
}
