
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class GiftRepository : IGiftRepository
    {
        private 
            ChineseSaleContext _context;
        public GiftRepository(ChineseSaleContext storeContext)
        {
            _context = storeContext;
        }
        //create
        public async Task AddGift(Gift gift)
        {
            await _context.Gifts.AddAsync(gift);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Gift?> GetGift(int id)
        {
            return await _context.Gifts.FindAsync(id);
        }
        public async Task<IEnumerable<Gift>> GetAllGifts()
        {
            return await _context.Gifts.ToListAsync();
        }
        //update
        public async Task UpdateGift(Gift gift)
        {
            _context.Gifts.Update(gift);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeleteGift(int id)
        {
            var cardCart = await _context.Gifts.FirstOrDefaultAsync(c => c.Id == id);
            if (cardCart != null)
            {
                _context.Gifts.Remove(cardCart);
            }
            await _context.SaveChangesAsync();
        }
    }
}