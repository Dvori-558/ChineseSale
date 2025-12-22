using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface IDonorRepository
    {
        Task AddDonor(Donor donor);
        Task DeleteDonor(int id);
        Task<IEnumerable<Donor>> GetAllDonors();
        Task<Donor?> GetDonor(int id);
        Task UpdateDonor(Donor donor);
    }
}