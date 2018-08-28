using System.Threading.Tasks;
using DirectionsApi.Models;

namespace DirectionsApi
{
    public interface IDirectionsService
    {
        string Key { set; }

        DirectionsResponse GetDirections(DirectionsRequest request);
        Task<DirectionsResponse> GetDirectionsAsync(DirectionsRequest request);
    }
}