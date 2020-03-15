using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private readonly IProizvodService _proizvodService;
        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Proizvod>> Get()
        {
            return Ok(_proizvodService.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Proizvod> GetById(int id)
        {
            var proizvodi = new List<Proizvod>
            {
                new Proizvod
                {
                    ProizvodId = 1,
                    Naziv = "Laptop"
                },
                new Proizvod
                {
                    ProizvodId = 2,
                    Naziv = "Monitor"
                }
            };

            foreach (var x in proizvodi)
            {
                if (x.ProizvodId == id)
                {
                    return x;
                }
            }

            return NotFound();
        }


        [HttpPost]
        public Proizvod Insert(Proizvod proizvod)
        {
            return new Proizvod {ProizvodId = -1, Naziv = proizvod.Naziv};
        }


        [HttpPut("{id}")]
        public ActionResult<Proizvod> Update(int id,Proizvod proizvod)
        {
            var proizvodi = new List<Proizvod>
            {
                new Proizvod
                {
                    ProizvodId = 1,
                    Naziv = "Laptop"
                },
                new Proizvod
                {
                    ProizvodId = 2,
                    Naziv = "Monitor"
                }
            };

            for(var i=0;i<proizvodi.Count;i++)
            {
                if (proizvodi[i].ProizvodId == id)
                {

                    proizvodi[i].Naziv = proizvod.Naziv;
                    return proizvodi[i];
                }
            }

            return NotFound();
        }
    }
}