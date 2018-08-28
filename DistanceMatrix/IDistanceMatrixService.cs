using System.Threading.Tasks;
using DistanceMatrix.Models;

namespace DistanceMatrix
{
    public interface IDistanceMatrixService
    {
        string Key { set; }

        DistanceMatrixResponse GetDirections(DistanceMatrixRequest request);
        Task<DistanceMatrixResponse> GetDirectionsAsync(DistanceMatrixRequest request);
    }
}