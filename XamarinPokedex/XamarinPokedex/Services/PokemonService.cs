using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPokedex.Models;
using XamarinPokedex.Utils;

namespace XamarinPokedex.Services
{
    public class PokemonService : IPokemonService
    {
        private PokemonBus _poke;
        private PokemonFull _single;

        public async Task<PokemonBus> GetAllAsync(string url)
        {
            using (HttpClient _client = new HttpClient())
            {
                HttpResponseMessage response = await _client.GetAsync(new Uri(url));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    _poke = JsonConvert.DeserializeObject<PokemonBus>(content);
                }

                return _poke;
            }           
        }

        public async Task<PokemonFull> GetSinglePoke(string url)
        {
            using (HttpClient _client2 = new HttpClient())
            {
                HttpResponseMessage response = await _client2.GetAsync(new Uri(url));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    _single = JsonConvert.DeserializeObject<PokemonFull>(content);
                }

                return _single;
            }
        }
    }
}
