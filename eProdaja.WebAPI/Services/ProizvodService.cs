using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.WebAPI.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvod, ProizvodSearchRequest, Proizvodi,ProizvodUpsertRequest, ProizvodUpsertRequest>
    {
        public ProizvodService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<List<Proizvod>> Get(ProizvodSearchRequest search)
        {
            var query = _context.Set<Proizvodi>().AsQueryable();

            if (search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }

            query = query.OrderBy(x => x.Naziv);

            return _mapper.Map<List<Model.Proizvod>>(await query.ToListAsync());
        }
    }
}