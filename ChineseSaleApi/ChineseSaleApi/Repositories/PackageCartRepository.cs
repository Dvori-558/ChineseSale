
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class PackageCartRepository : IPackageCartRepository
    {
        private readonly ChineseSaleContext _context;
        public PackageCartRepository(ChineseSaleContext context)
        {
            _context = context;
        }
        //create
        public async Task AddPackageCart(PackageCart packageCart)
        {
            await _context.PackageCarts.AddAsync(packageCart);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<PackageCart?> GetPackageCart(int id)
        {
            return await _context.PackageCarts.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<PackageCart>> GetAllPackageCarts()
        {
            return await _context.PackageCarts.ToListAsync();
        }
        //update
        public async Task UpdatePackageCart(PackageCart packageCart)
        {
            _context.PackageCarts.Update(packageCart);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeletePackageCart(int id)
        {
            var cardCart = await _context.PackageCarts.FirstOrDefaultAsync(c => c.Id == id);
            if (cardCart != null)
            {
                _context.PackageCarts.Remove(cardCart);
            }
            await _context.SaveChangesAsync();
        }
    }
}