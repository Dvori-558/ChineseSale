csharp ChineseSaleApi\Repositories\CardRepository.cs
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public class CardRepository : BaseRepository<Card>
    {
        public CardRepository(ChineseSaleContext context) : base(context) { }
    }
}