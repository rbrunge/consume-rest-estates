using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumeRestEstates.Integration
{
    public class EstateService
    {
        readonly HttpClient _client = new HttpClient();
        private const string Origin = "https://industrialenforcement.azurewebsites.net:443/api/v1.0/";
        private const string Operation = "estates";

        public async Task<Estate> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            var path = Origin + Operation + "/" + id;
            HttpResponseMessage response = await _client.GetAsync(path);
            string result = string.Empty;

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }
            var returnValue =
                JsonConvert.DeserializeObject<Estate>(result, ConsumeRestEstates.Integration.Converter.Settings);
            return returnValue;
        }


        public async Task<IEnumerable<Estate>> SearchAsync(/* takes 10 first */)
        {
            var path = Origin + Operation + "?take=10";
            HttpResponseMessage response = await _client.GetAsync(path);
            string result = string.Empty;

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }

            var returnValue =
                JsonConvert.DeserializeObject<Estate[]>(result, ConsumeRestEstates.Integration.Converter.Settings);
            return returnValue;
        }

    }
}