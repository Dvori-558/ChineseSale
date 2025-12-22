using ChineseSaleApi.Data;
using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class CardCartService
    {
        private 
            ChineseSaleContext _context;

        public CardCartService(ChineseSaleContext context)
        {
            _context = context;
        }
    }
}