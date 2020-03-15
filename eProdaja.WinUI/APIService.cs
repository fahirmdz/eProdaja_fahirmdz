using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public class APIService
    {
        private string _route = null;

        public APIService(string route)
        {
            _route = route;
        }


        public async Task<T> Get<T>()
        {
            var result = await $"{Properties.Settings.Default.API}/{_route}".GetJsonAsync<T>();
            return result;
        }
    }
}