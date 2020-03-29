using AutoMapper;
using eProdaja.WebAPI.Database;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual async Task<TModel> Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            await _context.Set<TDatabase>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
    }
}