﻿using eProdaja.WebAPI.Database;
using System.Collections.Generic;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.WebAPI.Services
{
    public interface IKorisniciService
    {
        Task<IList<Korisnik>> Get(KorisniciSearchRequest request);
        Task<Korisnik> GetById(int id);
        Task<Korisnik> Insert(KorisniciInsertRequest request);
        Task<Korisnik> Update(int id, KorisniciInsertRequest request);
        Task<Model.Korisnik> Authenticate(string username, string password);
    }
}