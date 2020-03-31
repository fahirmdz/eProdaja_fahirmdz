using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eProdajaContext _dbContext;
        private readonly IMapper _mapper;

        public KorisniciService(eProdajaContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IList<Korisnik>> Get(KorisniciSearchRequest request)
        {
            var korisnici = _dbContext.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Ime))
            {
                korisnici = korisnici.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request.Prezime))
            {
                korisnici = korisnici.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            return await korisnici.Select(x => _mapper.Map<Korisnik>(x)).ToListAsync();
        }

        public async Task<Korisnik> GetById(int id)
        {
            return _mapper.Map<Korisnik>(await _dbContext.Korisnici.FindAsync(id));
        }

        public async Task<Korisnik> Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Korisnici>(request);

            if (request.Password != request.PasswordConfirmation)
                throw new UserException("Passwordi se ne slazu!");

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            entity.Status = true;

            await _dbContext.AddAsync(entity);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            return _mapper.Map<Korisnik>(entity);
        }

        public async Task<Korisnik> Update(int id, KorisniciInsertRequest request)
        {
            var entity = await _dbContext.FindAsync<Korisnici>(id);

            if (entity == null)
            {
                throw new UserException("Korisnik nije pronadjen.");
            }

            _mapper.Map(request, entity);

            if (!string.IsNullOrEmpty(request.Password))
            {
                if (request.PasswordConfirmation != request.Password)
                {
                    throw new UserException("Passwordi se ne slazu!");
                }
            }

            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<Korisnik>(entity);
        }

        public async Task<Korisnik> Authenticate(string username, string password)
        {
            var user = await _dbContext.Korisnici.FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (user == null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, password);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnik>(user);
                }
            }

            return null;
        }

        private string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        private string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA512");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}