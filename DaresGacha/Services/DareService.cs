using AutoMapper;
using DaresGacha.Dtos.Dare;

namespace DaresGacha.Services;

public class DareService : BaseService<Dare>, IDareService
{
    public DareService(IRepository<Dare> repository, IMapper mapper) : base(repository, mapper) { }

    public async Task<ServiceResponse<int>> Add(DareAddDto newDare)
    {
        var dare = _mapper.Map<Dare>(newDare);
        return await base.Add(dare);
    }

    public async Task<ServiceResponse<IEnumerable<DareGetDto>>> GetAll(int? lvl, bool? done, bool? isDeleted)
    {
        var dares = await _repository.GetAll();

        if (lvl != null)
            dares = dares.Where(d => d.Level == lvl);
        if (done != null)
            dares = dares.Where(d => d.Done == done);
        if (isDeleted != null)
            dares = dares.Where(d => d.IsDeleted == isDeleted);

        return new ServiceResponse<IEnumerable<DareGetDto>>() { Data = _mapper.Map<List<DareGetDto>>(dares) };
    }

    public async Task<ServiceResponse<DareGetRandomDto>> GetRandom()
    {
        var done = (await _repository.GetAll()).Where(e => e.Done == true).Count();
        var difficulty = Calculator.GetProbability(done);
        var lvl = Calculator.GetLvl(difficulty);

        var dares = await _repository.GetAll();
        dares = FilterByLvl(dares, lvl, 0, difficulty.Length);

        if (dares.Count() == 0) return new ServiceResponse<DareGetRandomDto>() { Success = false, Exception = "No element found" };

        int i = new Random().Next(0, dares.Count());
        var chosenOne = dares.ToArray()[i];
        var mapped = _mapper.Map<DareGetRandomDto>(chosenOne);
        mapped.Difficulty = difficulty;
        return new ServiceResponse<DareGetRandomDto>() { Data = mapped };
    }

    public async Task<ServiceResponse<bool>> Update(DareUpdateDto newDare)
    {
        var dare = _mapper.Map<Dare>(newDare);
        return await base.Update(dare);
    }

    public async Task<ServiceResponse<bool>> Done(DareDoneDto done)
    {
        var dare = await _repository.Get(done.Id);
        if (dare == null) return new ServiceResponse<bool>() { Success = false, Exception = $"Dare with id {done.Id} not found" };

        if (done.Done) dare.Done = true;
        else dare.Skipped++;

        return await base.Update(dare);
    }

    private IEnumerable<Dare> FilterByLvl(IEnumerable<Dare> dares, int lvl, int minLvl, int maxLvl)
    {
        if (dares.Where(e => e.Level == lvl).Count() > 0)
            return dares.Where(e => e.Level == lvl);

        int originalLvl = lvl;
        //get dares of smaller level
        while (lvl >= minLvl)
        {
            if (dares.Where(e => e.Level == lvl).Count() > 0)
                return dares.Where(e => e.Level == lvl);
            lvl--;
        }
        //get dares of greater level
        lvl = originalLvl;
        while (lvl <= maxLvl)
        {
            if (dares.Where(e => e.Level == lvl).Count() > 0)
                return dares.Where(e => e.Level == lvl);
            lvl++;
        }
        return dares; //no elements
    }
}
