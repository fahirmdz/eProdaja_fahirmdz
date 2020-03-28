using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;
using JediniceMjere = eProdaja.WebAPI.Database.JediniceMjere;
using VrsteProizvoda = eProdaja.WebAPI.Database.VrsteProizvoda;

namespace eProdaja.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Korisnici, Korisnik>();
            CreateMap<Korisnici, KorisniciInsertRequest>().ReverseMap();

            CreateMap<Proizvodi, Model.Proizvod>().ReverseMap();

            CreateMap<JediniceMjere, Model.JediniceMjere>().ReverseMap();
            CreateMap<VrsteProizvoda, Model.VrsteProizvoda>().ReverseMap();
        }
    }
}