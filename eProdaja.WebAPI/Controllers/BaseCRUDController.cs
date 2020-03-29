using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Controllers
{
    public class BaseCRUDController<TModel, TSearch, TInsert, TUpdate> : BaseController<TModel, TSearch>
    {
        private readonly ICRUDService<TModel, TSearch, TInsert, TUpdate> _crudService;

        public BaseCRUDController(ICRUDService<TModel, TSearch, TInsert, TUpdate> crudService) : base(crudService)
        {
            _crudService = crudService;
        }

        [HttpPost]
        public async Task<TModel> Insert(TInsert request)
        {
            return await _crudService.Insert(request);
        }

        [HttpPut("{id}")]
        public async Task<TModel> Update(int id, TUpdate request)
        {
            return _crudService.Update(id, request);
        }
    }
}