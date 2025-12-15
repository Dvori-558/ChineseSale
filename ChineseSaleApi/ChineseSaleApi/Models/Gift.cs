using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChineseSaleApi.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }

        public int Price { get; set; }
        [MaxLength(250)]
        public string? ImageUrl { get; set; }
        [ForeignKey("Donor")]
        public int DonorId { get; set; }
        public Donor? Donor { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("WinnerUser")]
        public int WinnerUserId { get; set; }
        public User? WinnerUser { get; set; }

        public ICollection<User>? Inviters { get; set; }
    }
}
