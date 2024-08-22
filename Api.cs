using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Eris
{
    internal static class Api
    {
        public const string BASE = "https://purrbot.site/";

        // Animals

        public const string NEKO = "/img/sfw/neko/img";
        public const string KITSUNE = "/img/sfw/kitsune/img";
        public const string OOKAMI = "/img/sfw/okami/img";

        // Characters

        public const string HOLO = "/img/sfw/holo/img";
        public const string SENKO = "/img/sfw/senko/img";

        // Actions

        public const string PAT = "/img/sfw/pat/gif";
        public const string HUG = "/img/sfw/hug/gif";
        public const string POKE = "/img/sfw/poke/gif";
        public const string SLAP = "/img/sfw/slap/gif";
        public const string KISS = "/img/sfw/kiss/gif";

        // Client

        public static async Task<string> GetAsync(string url)
        {
            try
            {
                var prefixedUrl = $"/api{url}";
                var data = await HttpClient.GetFromJsonAsync<ApiResponse>(prefixedUrl);
                return data?.Link ?? "Error: Bad response";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        private static readonly HttpClient HttpClient = new()
        {
            BaseAddress = new Uri(BASE) 
        };

        private class ApiResponse
        {
            public string? Link { get; set; }
            public int Time { get; set; }
            public bool Error { get; set; }
        }
    }
}
