csharp ChineseSaleApi\Repositories\GiftRepository.cs
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public class GiftRepository : BaseRepository<Gift>
    {
        public GiftRepository(ChineseSaleContext context) : base(context) { }
    }
}