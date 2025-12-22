using ChineseSaleApi.Data;
using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class PackageCartService
    {
        private readonly IPackageCartRepository _packageCartRepository;

        public PackageCartService(IPackageCartRepository packageCartRepository)
        {
            _packageCartRepository = packageCartRepository;
        }
    }
}