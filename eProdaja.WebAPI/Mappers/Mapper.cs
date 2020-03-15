using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;

namespace eProdaja.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Korisnici, Korisnik>();
            CreateMap<Korisnici, KorisniciInsertRequest>().ReverseMap();


        }
    }
}