using System.Collections.Generic;
using eProdaja.Model;

namespace eProdaja.WebAPI.Services
{
    public class ProizvodService: IProizvodService
    {
        public IList<Proizvod> Get()
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

            return proizvodi;
        }
    }
}