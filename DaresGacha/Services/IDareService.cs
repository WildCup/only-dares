using DaresGacha.Dtos;

namespace DaresGacha.Services;

public interface IDareService
{
    Task<ServiceResponse<int>> Add(DareAddDto newDare);
    Task<ServiceResponse<bool>> Delete(int id);
    Task<ServiceResponse<IEnumerable<DareGetDto>>> GetAll(int? lvl, bool? done, bool? isDeleted);
    Task<ServiceResponse<DareGetRandomDto>> GetRandom();
    Task<ServiceResponse<bool>> Update(DareUpdateDto newDare);
    Task<ServiceResponse<bool>> Done(DareDoneDto done);
}
