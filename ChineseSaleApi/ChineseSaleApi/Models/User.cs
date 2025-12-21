using System.ComponentModel.DataAnnotations;

namespace ChineseSaleApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(15)]
        public string Password { get; set; }
        [MaxLength(30)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string? Phone { get; set; }

        public bool IsAdmin { get; set; } = false;

        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public ICollection<CardCart> CardCarts { get; set; } = new List<CardCart>();

        public ICollection<PackageCart> PackageCarts { get; set; } = new List<PackageCart>();
        public ICollection<Card> Cards { get; set; } = new List<Card>(); 
        //public ICollection<Gift>? WonGits { get; set; }
        //public ICollection<Gift>? InvitedGifts { get; set; }
    }
}
