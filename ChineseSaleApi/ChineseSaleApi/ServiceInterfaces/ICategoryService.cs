using ChineseSaleApi.Dtos;

namespace ChineseSaleApi.ServiceInterfaces
{
    public interface ICategoryService
    {
        Task AddCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(int id);
        Task<IEnumerable<CategoryDto>> GetAllCategories();
        Task<CategoryDto?> GetCategory(int id);
    }
}