csharp ChineseSaleApi\Repositories\CardCartRepository.cs
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public class CardCartRepository : BaseRepository<CardCart>
    {
        public CardCartRepository(ChineseSaleContext context) : base(context) { }
    }
}