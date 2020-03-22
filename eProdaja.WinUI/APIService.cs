﻿using System.Collections.Generic;
using System.Threading.Tasks;
using eProdaja.Model.Requests;
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


        public async Task<T> Get<T>(object search)
        {
            var url =  $"{Properties.Settings.Default.API}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.GetJsonAsync<T>();
        }
    }
}