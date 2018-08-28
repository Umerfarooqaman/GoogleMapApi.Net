using System.Threading.Tasks;
using DistanceMatrix.Models;

namespace DistanceMatrix
{
    public static class DirectionsExtentions
    {
        /// <summary>
        /// return DirectionsResponce using Direction service as a singleton 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DistanceMatrixResponse GetDirections(this DistanceMatrixRequest request)
        {
           return DistanceMatrixService.GetSingletonInstance().GetDirections(request);
        }
        /// <summary>
        /// return asynchronous  DirectionsResponce using Direction service as a singleton 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Task< DistanceMatrixResponse> GetDirectionsAsync(this DistanceMatrixRequest request)
        {
            return DistanceMatrixService.GetSingletonInstance().GetDirectionsAsync(request);
        }
    }
}
