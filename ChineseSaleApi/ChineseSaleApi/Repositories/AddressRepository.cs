using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ChineseSaleContext _context;
        public AddressRepository(ChineseSaleContext storeContext)
        {
            _context = storeContext;
        }
        //create
        public async Task AddForDonorAddress(Address address)
        {
            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();
        }
        public async Task AddForUserAddress(Address address)
        {
            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Address?> GetAddressById(int id)
        {
            return await _context.Addresses.FirstOrDefaultAsync(a => a.Id == id);
        }
        //update
        public async Task UpdateAddress(Address address)
        {
            _context.Addresses.Update(address);
            await _context.SaveChangesAsync();
        }
    }
}
