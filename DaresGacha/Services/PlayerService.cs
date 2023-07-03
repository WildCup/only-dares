using AutoMapper;
using DaresGacha.Dtos.Player;

namespace DaresGacha.Services;

public class PlayerService : BaseService<Player>, IPlayerService
{
    public PlayerService(IRepository<Player> repository, IMapper mapper) : base(repository, mapper) { }

    public async Task<ServiceResponse<int>> Add(PlayerAddDto newPlayer)
    {
        var player = _mapper.Map<Player>(newPlayer);
        return await base.Add(player);
    }

    public new async Task<ServiceResponse<IEnumerable<PlayerGetDto>>> GetAll()
    {
        var players = await _repository.GetAll();

        return new ServiceResponse<IEnumerable<PlayerGetDto>>() { Data = _mapper.Map<List<PlayerGetDto>>(players) };
    }

    public async Task<ServiceResponse<bool>> Update(PlayerUpdateDto newPlayer)
    {
        var player = _mapper.Map<Player>(newPlayer);
        return await base.Update(player);
    }

}
