using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface ICardRepository
    {
        Task<int> AddCard(Card card);
        Task<IEnumerable<Card?>> GetCardById(int id);
        Task<IEnumerable<Card>> GetAllCards();

        Task UpdateCard(Card card);
    }
}