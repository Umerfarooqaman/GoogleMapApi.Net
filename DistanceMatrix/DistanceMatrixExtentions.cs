using System.Threading.Tasks;
using DistanceMatrix.Models;

namespace DistanceMatrix
{
    public static class DistanceMatrixExtentions
    {
        /// <summary>
        /// return DirectionsResponce using Direction service as a singleton scope
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DistanceMatrixResponse GetDistanceMatrix(this DistanceMatrixRequest request)
        {
           return DistanceMatrixService.GetSingletonInstance().GetDistanceMatrix(request);
        }
        /// <summary>
        /// return asynchronous  DirectionsResponce using Direction service as a singleton scope
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Task< DistanceMatrixResponse> GetDistanceMatrixAsync(this DistanceMatrixRequest request)
        {
            return DistanceMatrixService.GetSingletonInstance().GetDistanceMatrixAsync(request);
        }


        
    }
}
