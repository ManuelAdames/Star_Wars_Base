using Newtonsoft.Json;
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
            var speciesResponse = await client.GetAsync($"{Config.ApiUrl}/planets/");

            if (speciesResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await speciesResponse.Content.ReadAsStringAsync();
                retVal = JsonConvert.DeserializeObject<Specie>(await speciesResponse.Content.ReadAsStringAsync()); ;
            }
            return retVal;
        }
    }
}
