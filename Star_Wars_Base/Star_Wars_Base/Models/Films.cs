using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<string> Characters { get; set; }

        [JsonProperty("planets")]
        public ObservableCollection<string> Planets { get; set; }

        [JsonProperty("starships")]
        public ObservableCollection<string> Starships { get; set; }

        [JsonProperty("vehicles")]
        public ObservableCollection<string> Vehicles { get; set; }

        [JsonProperty("species")]
        public ObservableCollection<string> Species { get; set; }

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

            [JsonProperty("results")]
            public ObservableCollection<Films> Results { get; set; }
        }
}