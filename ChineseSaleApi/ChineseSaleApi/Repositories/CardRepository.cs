using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
namespace ChineseSaleApi.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly ChineseSaleContext _context;
        public CardRepository(ChineseSaleContext storeContext)
        {
            _context = storeContext;
        }
        //create
        public async Task<int> AddCard(Card card)
        {
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();
            return card.Id;
        }
        //read
        public async Task<IEnumerable<Card?>> GetCardById(int id)
        {
            return await _context.Cards.Include(g=>g.Gift)
                .Include(u=>u.User).Where(c => c.GiftId == id)
                .ToListAsync();
        }
        public async Task<IEnumerable<Card>> GetAllCards()
        {
            return await _context.Cards.Include(g=>g.Gift)
                .ToListAsync();
        }
        //update
        public async Task UpdateCard(Card card)
        {
            _context.Cards.Update(card);
            await _context.SaveChangesAsync();
        }
    }
}