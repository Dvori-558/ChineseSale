using ChineseSaleApi.Dtos;
using static ChineseSaleApi.Dtos.CreateForUserAddressDto;

namespace ChineseSaleApi.ServiceInterfaces
{
    public interface IAddressService
    {
        Task<int> AddForUserAddress(CreateForUserAddressDto address);
        Task<int> AddForDonorAddress(CreateForDonorAddressDto address);

        Task<AddressDto?> GetAddressById(int id);
        Task UpdateAddress(AddressDto addressDto);
    }
}