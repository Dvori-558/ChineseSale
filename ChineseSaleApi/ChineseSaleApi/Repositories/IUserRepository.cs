using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User?> GetUserById(int id);
        Task<User?> GetUserByUserName(string userName);
        Task UpdateUser(User user);
    }
}