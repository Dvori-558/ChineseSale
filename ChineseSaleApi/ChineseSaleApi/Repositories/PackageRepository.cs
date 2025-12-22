
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class packageRepository : IpackageRepository
    {
        private readonly ChineseSaleContext _context;
        public packageRepository(ChineseSaleContext context)
        {
            _context = context;
        }
        //create
        public async Task AddPackage(Package package)
        {
            _context.Packages.AddAsync(package);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Package?> GetPackage(int id)
        {
            return await _context.Packages.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<Package>> GetAllPackages()
        {
            return await _context.Packages.ToListAsync();
        }
        //update
        public async Task UpdatePackage(Package package)
        {
            _context.Packages.Update(package);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeletePackage(int id)
        {
            var cardCart = await _context.Packages.FirstOrDefaultAsync(c => c.Id == id);
            if (cardCart != null) {
                _context.Packages.Remove(cardCart);
            }
            await _context.SaveChangesAsync();
        }
    }
}