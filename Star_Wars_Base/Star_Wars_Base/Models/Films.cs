using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars_Base.Models
{
    public class Films
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("episode_id")]
        public int EpisodeId { get; set; }

        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("characters")]
        public IList<string> Characters { get; set; }

        [JsonProperty("planets")]
        public IList<string> Planets { get; set; }

        [JsonProperty("starships")]
        public IList<string> Starships { get; set; }

        [JsonProperty("vehicles")]
        public IList<string> Vehicles { get; set; }

        [JsonProperty("species")]
        public IList<string> Species { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Film
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results_films")]
        public IList<Films> ResultsFilms { get; set; }
    }

}

