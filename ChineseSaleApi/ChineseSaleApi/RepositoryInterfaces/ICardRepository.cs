using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface ICardRepository
    {
        Task AddCard(Card card);
        Task<Card?> GetCard(int id);
        Task UpdateCard(Card card);
    }
}