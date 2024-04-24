using System.Linq.Expressions;
using DataAccess.Repositories.Interfaces;
using AutoMapper;
namespace Business_Logic.Services.Abstractions;

public class BaseCrudService<TEntity, TDto> : IBaseCrudService<TEntity, TDto>
    where TEntity : class
    where TDto : class
{

    protected readonly IBaseRepository<TEntity> _repository;
    protected readonly IMapper _mapper;
    public Task<TDto> Add(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<TDto> Update(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<TDto> Remove(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<TDto> Get(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TDto>> GetAll(Expression<Func<TEntity, bool>>? predicate = null)
    {
        throw new NotImplementedException();
    }
}