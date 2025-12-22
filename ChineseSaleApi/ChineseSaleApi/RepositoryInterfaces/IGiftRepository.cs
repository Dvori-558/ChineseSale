using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface IGiftRepository
    {
        Task AddGift(Gift gift);
        Task DeleteGift(int id);
        Task<IEnumerable<Gift>> GetAllGifts();
        Task<Gift?> GetGift(int id);
        Task UpdateGift(Gift gift);
    }
}