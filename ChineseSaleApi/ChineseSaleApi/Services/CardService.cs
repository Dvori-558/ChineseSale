using ChineseSaleApi.Data;
using ChineseSaleApi.Dtos;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using ChineseSaleApi.ServiceInterfaces;

namespace ChineseSaleApi.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        //create
        public async Task<int> AddCardAsync(CreateCardDto cardDto)
        {
            Card card = new Card
            {
                GiftId = cardDto.GiftId,
                UserId = cardDto.UserId
            };
            return await _cardRepository.AddCard(card);
        }
        //read
        public async Task<List<ListCardDto>> GetAllCard()
        {
            var cards = await _cardRepository.GetAllCards();
            return cards.
                GroupBy(x => new { x.Gift.Name, x.Gift.Id, x.Gift.ImageUrl })
                .Select(c =>
                new ListCardDto
                    {
                        GiftId = c.Key.Id,
                        GiftName = c.Key.Name,
                        ImageUrl = c.Key.ImageUrl,
                        Quantity = c.Count()
                    }
                ).ToList();
        }
        public async Task<CardDto?> GetCardById(int id)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var cards = await _cardRepository.GetCardById(id);
           
            var groupCards = cards.GroupBy(x => new { x.UserId, x.GiftId,x.Gift.Name,x.User.FirstName,x.User.LastName, })
                .Select(g=> new
                {
                    GiftId = g.Key.GiftId,
                    GiftName = g.Key.Name,
                    UserFirstName = g.Key.FirstName,
                    UserLastName = g.Key.LastName,
                    Count = g.Count()

                }).ToList();
            foreach (var item in groupCards)
            {
                dict.Add(item.UserFirstName + " " + item.UserLastName, item.Count);
            }
            return new CardDto
            {
                GiftId = id,
                GiftName = groupCards.FirstOrDefault()?.GiftName,
                CardPurchases = dict
            };
        }
    }
}