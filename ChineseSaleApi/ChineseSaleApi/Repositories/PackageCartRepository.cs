csharp ChineseSaleApi\Repositories\PackageCartRepository.cs
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public class PackageCartRepository : BaseRepository<PackageCart>
    {
        public PackageCartRepository(ChineseSaleContext context) : base(context) { }
    }
}