csharp ChineseSaleApi\Repositories\LotteryRepository.cs
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public class LotteryRepository : BaseRepository<Lottery>
    {
        public LotteryRepository(ChineseSaleContext context) : base(context) { }
    }
}