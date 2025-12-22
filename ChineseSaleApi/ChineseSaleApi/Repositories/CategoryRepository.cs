using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ChineseSaleContext _context;
        public CategoryRepository(ChineseSaleContext context)
        {
            _context = context;
        }
        //create
        public async Task AddCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Category?> GetCategory(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }
        //update
        public async Task UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeleteCategory(int id)
        {
            var cardCart = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (cardCart != null)
            {
                _context.Categories.Remove(cardCart);
            }
            await _context.SaveChangesAsync();
        }
    }
}
