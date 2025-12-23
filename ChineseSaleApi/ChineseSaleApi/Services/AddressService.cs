using ChineseSaleApi.Dtos;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using ChineseSaleApi.ServiceInterfaces;
using static ChineseSaleApi.Dtos.CreateForUserAddressDto;

namespace ChineseSaleApi.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        //create
        public async Task<int> AddForUserAddress(CreateForUserAddressDto address)
        {
            Address address1 = new Address()
            {
                Street = address.Street,
                City = address.City,
                Number = address.Number,
                ZipCode = address.ZipCode
            };
            return await _addressRepository.AddForUserAddress(address1);
           
        }
        public async Task<int> AddForDonorAddress(CreateForDonorAddressDto address)
        {
            Address address1 = new Address()
            {
                Street = address.Street,
                City = address.City,
                Number = address.Number,
                ZipCode = address.ZipCode
            };
            return await _addressRepository.AddForDonorAddress(address1);
        }
        //read
        public async Task<AddressDto?> GetAddressById(int id)
        {
            var address = await _addressRepository.GetAddressById(id);
            if (address == null)
            {
                return null;
            }
            return new AddressDto
            {
                Id = address.Id,
                Street = address.Street,
                City = address.City,
                Number = address.Number,
                ZipCode = address.ZipCode
            };
        }
        //update
        public async Task UpdateAddress(AddressDto addressDto)
        {
            var address = await _addressRepository.GetAddressById(addressDto.Id);
            if (address != null)
            {
                address.Street = addressDto.Street;
                address.City = addressDto.City;
                address.Number = addressDto.Number;
                address.ZipCode = addressDto.ZipCode;
                await _addressRepository.UpdateAddress(address);
            }
        }
        //delete
    }
}
