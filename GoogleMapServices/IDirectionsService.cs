using System.Threading.Tasks;
using GoogleMapServices.Models;

namespace GoogleMapServices
{
    public interface IDirectionsService
    {
        /// <summary>
        ///set default Authentication Key provided by Google map 
        /// </summary>
        string Key { set; }

        /// <summary>
        /// Initiate asynchronous Google direction API request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DirectionsResponse GetDirections(DirectionsRequest request);

        /// <summary>
        /// Initiate Google direction API request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DirectionsResponse> GetDirectionsAsync(DirectionsRequest request);
    }
}