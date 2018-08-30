using System.Threading.Tasks;
using GoogleMapServices.Models;

namespace GoogleMapServices
{
    public interface IDistanceMatrixService
    {
        string Key { set; }
        /// <summary>
        /// Initiate Google Distance Matrix API request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DistanceMatrixResponse GetDistanceMatrix(DistanceMatrixRequest request);
        /// <summary>
        /// Initiate asynchronous Google Distance Matrix API request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DistanceMatrixResponse> GetDistanceMatrixAsync(DistanceMatrixRequest request);
    }
}