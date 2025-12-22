using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;

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
        public async Task AddCard(Card card)
        {
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Card?> GetCard(int id)
        {
            return await _context.Cards.FindAsync(id);
        }
        //update
        public async Task UpdateCard(Card card)
        {
            _context.Cards.Update(card);
            await _context.SaveChangesAsync();
        }
    }
}