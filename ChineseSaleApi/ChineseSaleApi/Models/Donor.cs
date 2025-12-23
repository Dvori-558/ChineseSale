using System.ComponentModel.DataAnnotations;

namespace ChineseSaleApi.Models
{
    public class Donor
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string? FirstName { get; set; }
        [MaxLength(30)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string CompanyName { get; set; }
        [Required]
        [EmailAddress]
        public string CompanyEmail { get; set; }
        [Phone]
        public string? CompanyPhone {  get; set; }
        [MaxLength(250)]
        public string? CompanyIcon {  get; set; }
        public int CompanyAddressId { get; set; }
        public Address? CompanyAddress { get; set; }
        public ICollection<Gift> Gifts { get; set; } = new List<Gift>();
        public ICollection<Lottery> Lotteries { get; set; }= new List<Lottery>();
    }
}