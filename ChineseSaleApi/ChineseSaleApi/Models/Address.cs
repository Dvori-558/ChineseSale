using System.ComponentModel.DataAnnotations;

namespace ChineseSaleApi.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        public int Number { get; set; }

        public int ZipCode { get; set; }

        public ICollection<User>? Users { get; set; }
        public ICollection<Donor>? Donors { get; set; }

    }
}
