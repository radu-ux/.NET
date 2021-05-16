using System;
using System.Net.Http;
using UniversityDorms.models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace UniversityDorms.services
{
    public partial class HttpJsonDataService
    {
        public List<Dorm> GetDorms()
        {
            HttpClient httpClient = new HttpClient();
            string api_key = Environment.GetEnvironmentVariable("API_KEY");
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", api_key);
            var response = httpClient.GetAsync(App.DORMS_URL).Result;
            string responseMessage = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<DormList>(responseMessage);
            return responseObject.Dorms;
        }

        public List<User> GetUsers()
        {
            HttpClient httpClient = new HttpClient();
            string api_key = Environment.GetEnvironmentVariable("API_KEY1");
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", api_key);
            var response = httpClient.GetAsync(App.USERS_URL).Result;
            string responseMessage = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<UserList>(responseMessage);
            return responseObject.Users;
        }

        public async Task StoreUser(User user)
        {
            Console.WriteLine("FUNCTION ENTERED");
            HttpClient httpClient = new HttpClient();
            string api_key = Environment.GetEnvironmentVariable("API_KEY2");
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", api_key);
            string json = JsonConvert.SerializeObject(user);
            Console.WriteLine("HERE" + json);
            StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(App.STORE_USER_URL, content);
        }
    }   
}
