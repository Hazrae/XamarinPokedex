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
        private HttpClient _client;
        private PokemonBus _poke;      

        public async Task<PokemonBus> GetAllAsync(string uri = "https://pokeapi.co/api/v2/pokemon/")
        {           
            _client = new HttpClient();
            var response = await _client.GetAsync(new Uri(uri));
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                _poke = JsonConvert.DeserializeObject<PokemonBus>(content);               
            }

            return _poke;
        }
    }
}
