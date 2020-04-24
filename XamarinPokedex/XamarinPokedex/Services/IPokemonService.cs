using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinPokedex.Models;

namespace XamarinPokedex.Services
{
    public interface IPokemonService
    {
        Task<PokemonBus> GetAllAsync(string uri = "https://pokeapi.co/api/v2/pokemon/");
    }
}