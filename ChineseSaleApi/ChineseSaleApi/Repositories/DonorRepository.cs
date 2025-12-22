using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class DonorRepository : IDonorRepository
    {
        private readonly ChineseSaleContext _context;
        public DonorRepository(ChineseSaleContext storeContext)
        {
            _context = storeContext;
        }
        //create
        public async Task AddDonor(Donor donor)
        {
            await _context.Donors.AddAsync(donor);
            await _context.SaveChangesAsync();
        }
        //raed
        public async Task<Donor?> GetDonor(int id)
        {
            return await _context.Donors.FirstOrDefaultAsync(d => d.Id == id);
        }
        public async Task<IEnumerable<Donor>> GetAllDonors()
        {
            return await _context.Donors.ToListAsync();
        }
        //update
        public async Task UpdateDonor(Donor donor)
        {
            _context.Donors.Update(donor);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeleteDonor(int id)
        {
            var cardCart = await _context.Donors.FirstOrDefaultAsync(c => c.Id == id);
            if (cardCart != null)
            {
                _context.Donors.Remove(cardCart);
            }
            await _context.SaveChangesAsync();
        }
    }
}
