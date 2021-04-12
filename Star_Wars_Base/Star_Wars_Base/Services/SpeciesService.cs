using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public class SpeciesService : ISpeciesService
    {
        public async Task<Specie> GetSpecieAsync()
        {
            Specie retVal = null;

            HttpClient client = new HttpClient();
            var specieResponse = await client.GetAsync($"{Config.ApiUrl}/planets/");

            if (specieResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await specieResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<Specie>(jsonPayLoad);
            }
            return retVal;
        }
    }
}
