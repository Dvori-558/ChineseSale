using ChineseSaleApi.Dtos;
using ChineseSaleApi.Models;
using static ChineseSaleApi.Dtos.CreateForUserAddressDto;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface IAddressRepository
    {
        Task AddForUserAddress(Address address);
        Task AddForDonorAddress(Address address);

        Task<Address?> GetAddressById(int id);
        Task UpdateAddress(Address address);
    }
}