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
        public async Task<int> AddForDonorAddress(Address address)
        {
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();
            return address.Id;
        }
        public async Task<int> AddForUserAddress(Address address)
        {
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();
            return address.Id;
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
