using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public class PeopleService : IPeopleService
    {
        public async Task<Person> GetPeopleAsync()
        {
            Person retVal = null;

            HttpClient client = new HttpClient();
            var peopleResponse = await client.GetAsync($"{Config.ApiUrl}/people/");

            if (peopleResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await peopleResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<Person>(jsonPayLoad);
            }
            return retVal;
        }
    }
}
