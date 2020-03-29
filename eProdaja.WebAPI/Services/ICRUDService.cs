using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface ICRUDService<TModel,TSearch, TInsert, TUpdate>:IService<TModel,TSearch>
    {
        Task<TModel> Insert(TInsert request);

        TModel Update(int id, TUpdate request);
    }
}