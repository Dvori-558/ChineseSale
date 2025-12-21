csharp ChineseSaleApi\Repositories\PackageRepository.cs
using ChineseSaleApi.Data;
using ChineseSaleApi.Models;

namespace ChineseSaleApi.Repositories
{
    public class PackageRepository : BaseRepository<Package>
    {
        public PackageRepository(ChineseSaleContext context) : base(context) { }
    }
}