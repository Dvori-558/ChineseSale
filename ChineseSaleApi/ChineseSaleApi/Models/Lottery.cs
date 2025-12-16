using System.ComponentModel.DataAnnotations;

namespace ChineseSaleApi.Models
{
    public class Lottery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int TotalCards { get; set; }
        public int TotalSum { get; set; }
        public ICollection<Package> Packages { get; set; }=new List<Package>();
    }
}
