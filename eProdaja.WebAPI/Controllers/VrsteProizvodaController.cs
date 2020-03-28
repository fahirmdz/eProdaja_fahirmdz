using eProdaja.Model;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    public class VrsteProizvodaController : BaseController<Model.VrsteProizvoda,object>
    {
        public VrsteProizvodaController(IService<VrsteProizvoda, object> service) : base(service)
        {
        }
    }
}