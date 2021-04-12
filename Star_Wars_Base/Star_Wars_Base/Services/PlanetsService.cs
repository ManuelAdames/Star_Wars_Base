using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public class PlanetsService : IPlanetsService
    {
        public async Task<Planet> GetPlanetAsync()
        {
            Planet retVal = null;

            HttpClient client = new HttpClient();
            var planetResponse = await client.GetAsync($"{Config.ApiUrl}/planets/");

            if (planetResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await planetResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<Planet>(jsonPayLoad);
            }
            return retVal;
        }
    }
}
