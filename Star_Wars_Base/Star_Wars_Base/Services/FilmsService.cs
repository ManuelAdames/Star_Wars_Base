using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public class FilmsService : IFilmsService
    {
        public async Task<Film> GetFilmAsync()
        {
            Film retVal = null;

            HttpClient client = new HttpClient();
            var filmResponse = await client.GetAsync("https://swapi.dev/api/films/");

            if (filmResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await filmResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<Film>(jsonPayLoad);
            }
            return retVal;
        }
    }
}