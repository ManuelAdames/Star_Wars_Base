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
            var vehicleResponse = await client.GetAsync($"{Config.ApiUrl}/vehicles/");

            if (vehicleResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await vehicleResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<Vehicle>(jsonPayLoad);
            }
            return retVal;
        }
    }
}
