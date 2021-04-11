using System;
using System.Collections.Generic;
using System.Text;
using Star_Wars_Base.Models;

namespace Star_Wars_Base.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption Films { get; set; } = new MenuOption();
        public MenuOption People { get; set; } = new MenuOption();
        public MenuOption Planets { get; set; } = new MenuOption();
        public MenuOption Species { get; set; } = new MenuOption();
        public MenuOption Starships { get; set; } = new MenuOption();
        public MenuOption Vehicles { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            Films.Title = "Films"; //Films.Image = ".png";
            People.Title = "People"; //People.Image = ".png";
            Planets.Title = "Planets"; //Planets.Image = ".png";
            Species.Title = "Species"; //Species.Image = ".png";
            Starships.Title = "Starships"; //Starships.Image = ".png";
            Vehicles.Title = "Vehicles"; //Vehicles.Image = ".png";
        }

    }
}
