using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Services;

namespace eProdaja.WebAPI.Controllers
{
    public class ProizvodController : BaseController<Model.Proizvod, ProizvodSearchRequest>
    {
        public ProizvodController(IService<Proizvod, ProizvodSearchRequest> service) : base(service)
        {
        }
    }
}