using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Services;

namespace eProdaja.WebAPI.Controllers
{
    public class ProizvodController : BaseCRUDController<Model.Proizvod,ProizvodSearchRequest,ProizvodUpsertRequest,ProizvodUpsertRequest>
    {
        public ProizvodController(ICRUDService<Proizvod, ProizvodSearchRequest, ProizvodUpsertRequest, ProizvodUpsertRequest> crudService) : base(crudService)
        {
        }
    }
}