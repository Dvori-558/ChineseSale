namespace ChineseSaleApi.Repositories
{
    public class UserRepository
    {
        private readonly ChineseSaleContext _context;
        public UserRepository(ChineseSaleContext context)
        {
            _context = context;
        }
}