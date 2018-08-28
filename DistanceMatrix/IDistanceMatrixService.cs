using System.Threading.Tasks;
using DistanceMatrix.Models;

namespace DistanceMatrix
{
    public interface IDistanceMatrixService
    {
        string Key { set; }

        DistanceMatrixResponse GetDistanceMatrix(DistanceMatrixRequest request);
        Task<DistanceMatrixResponse> GetDistanceMatrixAsync(DistanceMatrixRequest request);
    }
}