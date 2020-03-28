using AutoMapper;
using eProdaja.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        protected readonly eProdajaContext _context;
        protected readonly IMapper _mapper;

        public BaseService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<List<TModel>> Get(TSearch search)
        {
            return _mapper.Map<List<TModel>>(await _context.Set<TDatabase>().ToListAsync());
        }

        public virtual async Task<TModel> GetById(int id)
        {
            return _mapper.Map<TModel>(await _context.Set<TDatabase>().FindAsync(id));
        }
    }
}