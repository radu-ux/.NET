using System;
using System.Net.Http;
using UniversityDorms.models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UniversityDorms.services
{
    public partial class HttpJsonDataService
    {
        public List<Dorm> GetDorms()
        {
            HttpClient httpClient = new HttpClient();
            string api_key = Environment.GetEnvironmentVariable("API_KEY");
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", api_key);
            var response = httpClient.GetAsync(App.URL).Result;
            string responseMessage = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<DormList>(responseMessage);
            return responseObject.Dorms;
        }
    }
}
