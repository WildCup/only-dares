using AutoMapper;

namespace DaresGacha.Services
{
    public abstract class BaseService<T> where T : Base
    {
        protected readonly IRepository<T> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public virtual async Task<ServiceResponse<int>> Add(Base entity)
        {
            try
            {
                var id = await _repository.Add(entity);
                return new ServiceResponse<int>() { Data = id };
            }
            catch (Exception e)
            {
                return new ServiceResponse<int>()
                {
                    Success = false,
                    Exception = e.Message
                };
            }
        }

        public virtual async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                await _repository.Delete(id);
                return new ServiceResponse<bool>();
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Exception = e.Message
                };
            }
        }

        public virtual async Task<ServiceResponse<T>> Get(int id)
        {
            try
            {
                var entity = await _repository.Get(id);
                return new ServiceResponse<T>() { Data = entity };
            }
            catch (Exception e)
            {
                return new ServiceResponse<T>()
                {
                    Success = false,
                    Exception = e.Message
                };
            }
        }

        public virtual async Task<ServiceResponse<IEnumerable<T>>> GetAll()
        {
            try
            {
                var list = await _repository.GetAll();
                return new ServiceResponse<IEnumerable<T>>() { Data = list };
            }
            catch (Exception e)
            {
                return new ServiceResponse<IEnumerable<T>>()
                {
                    Success = false,
                    Exception = e.Message
                };
            }
        }

        public virtual async Task<ServiceResponse<bool>> Update(T entity)
        {
            try
            {
                await _repository.Update(entity);
                return new ServiceResponse<bool>();
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Exception = e.Message
                };
            }
        }
    }
}