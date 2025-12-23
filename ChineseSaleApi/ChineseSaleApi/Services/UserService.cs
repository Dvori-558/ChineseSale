using ChineseSaleApi.Dtos;
using ChineseSaleApi.Models;
using ChineseSaleApi.Repositories;
using ChineseSaleApi.RepositoryInterfaces;
using ChineseSaleApi.ServiceInterfaces;


namespace ChineseSaleApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressService _addressService;
        public UserService(IUserRepository userRepository, IAddressService addressService)
        {
            _userRepository = userRepository;
            _addressService = addressService;

        }
        //create
        public async Task AddUser(CreateUserDto userDto)
        {
            int idAddress = await _addressService.AddForUserAddress(userDto.Address);
            User user = new User
            {
                UserName = userDto.UserName,
                Password = userDto.Password,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Phone = userDto.Phone,
                AddressId = idAddress

            };
            await _userRepository.AddUser(user);
        }
        //read
        public async Task<UserDto?> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                return null;
            }
            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                Address = user.Address != null ? new AddressDto
                {
                    Id = user.Address.Id,
                    Street = user.Address.Street,
                    City = user.Address.City,
                    Number = user.Address.Number,
                    ZipCode = user.Address.ZipCode
                } : null,
            };
        }
        //update
        public async Task UpdateUser(UpdateUserDto userDto)
        {
            var user = await _userRepository.GetUserById(userDto.Id);
            await _addressService.UpdateAddress(userDto.Address);
            if (user != null)
            {
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.Email = userDto.Email;
                user.Phone = userDto.Phone;
                await _userRepository.UpdateUser(user);
            }
        }

    }
}