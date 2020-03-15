using System.Collections;
using System.Collections.Generic;
using eProdaja.Model;

namespace eProdaja.WebAPI.Services
{
    public interface IProizvodService
    {
        IList<Proizvod> Get();

    }
}