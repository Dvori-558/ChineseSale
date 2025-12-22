using ChineseSaleApi.Data;
using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class CardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
    }
}