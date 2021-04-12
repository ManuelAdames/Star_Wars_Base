using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public class StarShipsService : IStarShipsService
    {
        public async Task<StarShip> GetStarShipAsync()
        {
            StarShip retVal = null;

            HttpClient client = new HttpClient();
            var starshipResponse = await client.GetAsync($"{Config.ApiUrl}/starships/");

            if (starshipResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await starshipResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<StarShip>(jsonPayLoad);
            }
            return retVal;
        }
    }
}
