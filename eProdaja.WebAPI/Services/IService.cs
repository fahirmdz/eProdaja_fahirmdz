using System.Collections.Generic;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface IService<TModel,TSearch>
    {
        Task<List<TModel>> Get(TSearch search);

        Task<TModel> GetById(int id);
    }
}