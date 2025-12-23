namespace ChineseSaleApi.Dtos
{
    public class CreateUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public CreateForUserAddressDto? Address { get; set; }
    }
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public AddressDto? Address { get; set; }
        public bool IsAdmin { get; set; }
    }
    public class UpdateUserDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public AddressDto? Address { get; set; }
    }
}