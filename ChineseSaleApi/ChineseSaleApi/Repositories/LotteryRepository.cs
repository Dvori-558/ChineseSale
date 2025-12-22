using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class LotteryRepository : ILotteryRepository
    {
        private readonly ChineseSaleContext _context;
        public LotteryRepository(ChineseSaleContext storeContext)
        {
            _context = storeContext;
        }
        //create
        public async Task AddLottery(Lottery lottery)
        {
            _context.Lotteries.AddAsync(lottery);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Lottery?> GetLotteryById(int id)
        {
            return await _context.Lotteries.FindAsync(id);
        }
        public async Task<IEnumerable<Lottery>> GetAllLotteries()
        {
            return await _context.Lotteries.ToListAsync();
        }
        //update
        public async Task UpdateLottery(Lottery lottery)
        {
            _context.Lotteries.Update(lottery);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeleteLottery(int id)
        {
            var cardCart = await _context.Lotteries.FirstOrDefaultAsync(c => c.Id == id);
            if (cardCart != null)
            {
                _context.Lotteries.Remove(cardCart);
            }
            await _context.SaveChangesAsync();
        }
    }
}