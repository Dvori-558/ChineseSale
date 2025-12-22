using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class PackageService
    {
        private readonly IpackageRepository _packageRepository;

        public PackageService(IpackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }
    }
}