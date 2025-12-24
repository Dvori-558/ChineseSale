using ChineseSaleApi.Dtos;

namespace ChineseSaleApi.ServiceInterfaces
{
    public interface ICardService
    {
        Task<int> AddCardAsync(CreateCardDto cardDto);
        Task<List<ListCardDto>> GetAllCard();
        Task<CardDto?> GetCardById(int id);
    }
}