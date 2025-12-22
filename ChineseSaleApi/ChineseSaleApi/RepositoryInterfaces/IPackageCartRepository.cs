using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface IPackageCartRepository
    {
        Task AddPackageCart(PackageCart packageCart);
        Task DeletePackageCart(int id);
        Task<IEnumerable<PackageCart>> GetAllPackageCarts();
        Task<PackageCart?> GetPackageCart(int id);
        Task UpdatePackageCart(PackageCart packageCart);
    }
}