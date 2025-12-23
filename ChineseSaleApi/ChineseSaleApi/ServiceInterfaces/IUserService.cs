using ChineseSaleApi.Dtos;

namespace ChineseSaleApi.ServiceInterfaces
{
    public interface IUserService
    {
        Task AddUser(CreateUserDto userDto);
        Task<UserDto?> GetUserById(int id);
        Task UpdateUser(UpdateUserDto userDto);
    }
}