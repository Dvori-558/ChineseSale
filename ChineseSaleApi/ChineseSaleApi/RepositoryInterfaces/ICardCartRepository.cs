
using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface ICardCartRepository
    {
        Task AddCardCart(CardCart cardCart);
        Task DeleteCardCart(int id);
        Task<IEnumerable<CardCart>> GetAllCardCarts();
        Task<CardCart?> GetCardCart(int id);
        Task UpdateCardCart(CardCart cardCart);
    }
}