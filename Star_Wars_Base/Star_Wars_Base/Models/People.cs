﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars_Base.Models
{
    public class People
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("mass")]
        public string Mass { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("films")]
        public IList<string> Films { get; set; }

        [JsonProperty("species")]
        public IList<string> Species { get; set; }

        [JsonProperty("vehicles")]
        public IList<string> Vehicles { get; set; }

        [JsonProperty("starships")]
        public IList<string> Starships { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Person
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results_people")]
        public IList<People> ResultsPeople { get; set; }
    }
}

