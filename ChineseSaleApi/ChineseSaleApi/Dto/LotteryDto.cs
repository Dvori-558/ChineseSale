namespace ChineseSaleApi.Dtos
{
    public class LotteryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? TotalCards { get; set; }
        public int? Totalsum { get; set; }
        public bool IsDone { get; set; }
    }
    public class CreateLotteryDto
    {
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }       

}