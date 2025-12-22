using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class GiftService
    {
        private readonly IGiftRepository _giftRepository;

        public GiftService(IGiftRepository giftRepository)
        {
            _giftRepository = giftRepository;
        }
    }
}
