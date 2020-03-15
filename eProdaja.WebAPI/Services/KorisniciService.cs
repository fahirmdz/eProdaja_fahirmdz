using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.WebAPI.Services
{
    public class KorisniciService: IKorisniciService
    {
        private readonly eProdajaContext _dbContext;
        private readonly IMapper _mapper;

        public KorisniciService(eProdajaContext dbContext, 
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IList<Korisnik>> Get()
        {
            return await _dbContext.Korisnici
                .Select(x => _mapper.Map<Korisnik>(x))
                .ToListAsync();
        }

        public async Task<Korisnik> Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Korisnici>(request);

            if (request.Password != request.PasswordConfirmation)
                throw new UserException("Passwordi se ne slazu!");

            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test";

            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<Korisnik>(entity);
        }
    }
}