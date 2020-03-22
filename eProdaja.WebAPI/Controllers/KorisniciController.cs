using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _korisniciService;
        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }

        [HttpGet]
        public async Task<IList<Korisnik>> Get([FromQuery]KorisniciSearchRequest request)
        {
            return await _korisniciService.Get(request);
        }

        [HttpPost]
        public async Task<Korisnik> Insert(KorisniciInsertRequest model)
        {
            return await _korisniciService.Insert(model);
        }
    }
}