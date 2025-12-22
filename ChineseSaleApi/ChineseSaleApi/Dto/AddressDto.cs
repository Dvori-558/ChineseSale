
namespace ChineseSaleApi.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int? Number { get; set; }
        public int? ZipCode { get; set; }
    }
    public class CreateForUserAddressDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int? Number { get; set; }
        public int? ZipCode { get; set; }
        public int? UserId
        {
            get; set;
        }
        public class CreateForDonorAddressDto
        {
            public string Street { get; set; }
            public string City { get; set; }
            public int? Number { get; set; }
            public int? ZipCode { get; set; }
            public int? DonorId { get; set; }
        }
    }
}