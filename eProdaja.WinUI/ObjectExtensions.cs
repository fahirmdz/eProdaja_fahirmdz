using Flurl.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eProdaja.WinUI
{
    public static class ObjectExtensions
    {
        public static JsonSerializer JsonSerializerSettings;

        static ObjectExtensions()
        {
            JsonSerializerSettings = new JsonSerializer();
            JsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            JsonSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            JsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public static IDictionary<string, string> ToKeyValue(this object metaToken)
        {
            if (metaToken == null)
                return null;

            JToken token = metaToken as JToken;
            ;
            if (token == null)
            {
                try
                {
                    return ToKeyValue(JObject.FromObject(metaToken, JsonSerializerSettings));
                }
                catch (System.ArgumentException ex)
                {
                    var dict = new Dictionary<string, string>();
                    dict.Add("id", metaToken.ToString());
                    return dict;
                }
            }

            if (token.HasValues)
            {
                var contentData = new Dictionary<string, string>();
                foreach (var child in token.Children().ToList())
                {
                    var childContent = child.ToKeyValue();
                    if (childContent != null)
                    {
                        contentData = contentData.Concat(childContent)
                            .ToDictionary(k => k.Key, v => v.Value);
                    }
                }

                return contentData;
            }

            var jValue = token as JValue;
            if (jValue?.Value == null)
            {
                return null;
            }

            var value = jValue?.Type == JTokenType.Date
                ? jValue?.ToString("u", CultureInfo.InvariantCulture)
                : jValue?.ToString(CultureInfo.InvariantCulture);

            var res =  new Dictionary<string, string>();
            res.Add(token.Path,value);

            return res;
        }

        public static async Task<string> ToQueryString(this object metaToken)
        {
            var keyValueContent = metaToken.ToKeyValue();
            var formUrlEncodedContent = new FormUrlEncodedContent(keyValueContent);
            var urlEncodedString = await formUrlEncodedContent.ReadAsStringAsync();

            return urlEncodedString;
        }


        public static async Task<string> WithQueryString(this string url, object metaToken)
        {
            if (metaToken != null)
            {
                url += await metaToken.ToQueryString();
            }

            return url;
        }
    }
}