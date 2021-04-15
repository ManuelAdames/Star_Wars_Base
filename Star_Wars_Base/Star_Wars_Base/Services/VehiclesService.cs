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
    public class VehiclesService : IVehiclesService
    {
        public async Task<Vehicle> GetVehicleAsync()
        {
            Vehicle retVal = null;

            HttpClient client = new HttpClient();
            var vehicleResponse = await client.GetAsync("https://swapi.dev/api/vehicles/");

            if (vehicleResponse.IsSuccessStatusCode)
            {
                retVal = JsonConvert.DeserializeObject<Vehicle>(await vehicleResponse.Content.ReadAsStringAsync()); ;
            }
            return retVal;
        }
    }
}
