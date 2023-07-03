using DaresGacha.Dtos.Player;

namespace DaresGacha.Services;

public interface IPlayerService
{
    Task<ServiceResponse<int>> Add(PlayerAddDto newPlayer);
    Task<ServiceResponse<bool>> Delete(int id);
    Task<ServiceResponse<IEnumerable<PlayerGetDto>>> GetAll();
    Task<ServiceResponse<bool>> Update(PlayerUpdateDto newPlayer);
}
