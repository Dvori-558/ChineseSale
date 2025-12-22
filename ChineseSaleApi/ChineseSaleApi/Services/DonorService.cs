using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class DonorService
    {
        private readonly IDonorRepository _donorRepository;

        public DonorService(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository;
        }
    }
}
