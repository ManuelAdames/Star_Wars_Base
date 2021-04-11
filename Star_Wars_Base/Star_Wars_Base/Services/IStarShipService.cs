using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public interface IStarShipService
    {
        Task<StarShip> GetStarShipAsync();
    }
}
