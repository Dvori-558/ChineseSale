using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class UserService
    {
        private 
            IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
