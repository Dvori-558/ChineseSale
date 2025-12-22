using ChineseSaleApi.Dtos;
using static ChineseSaleApi.Dtos.CreateForUserAddressDto;

namespace ChineseSaleApi.ServiceInterfaces
{
    public interface IAddressService
    {
        Task AddForUserAddress(CreateForUserAddressDto address);
        Task AddForDonorAddress(CreateForDonorAddressDto address);

        Task<AddressDto?> GetAddressById(int id);
    }
}