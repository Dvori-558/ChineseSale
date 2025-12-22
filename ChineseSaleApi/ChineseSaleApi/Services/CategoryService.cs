using ChineseSaleApi.Dtos;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using ChineseSaleApi.ServiceInterfaces;

namespace ChineseSaleApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        //create
        public async Task AddCategory(CreateCategoryDto categoryDto)
        {
            Category category = new Category
            {
                Name = categoryDto.Name
            };
            await _categoryRepository.AddCategory(category);
        }
        //read
        public async Task<CategoryDto?> GetCategory(int id)
        {
            var category = await _categoryRepository.GetCategory(id);
            if (category == null)
            {
                return null;
            }
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name
            };
        }
        public async Task<IEnumerable<CategoryDto>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
        }
        //delete
        public async Task DeleteCategory(int id)
        {
            var category = await _categoryRepository.GetCategory(id);
            if (category != null)
            {
                await _categoryRepository.DeleteCategory(id);
            }
        }
    }
}
