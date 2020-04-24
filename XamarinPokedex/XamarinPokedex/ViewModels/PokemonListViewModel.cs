using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinPokedex.Models;
using XamarinPokedex.Services;
using XamarinPokedex.Utils;

namespace XamarinPokedex.ViewModels
{
    class PokemonListViewModel : ViewModelBase
    {

		private PokemonBus _pokeBus;

		public PokemonBus PokeBus
		{
			get { return _pokeBus; }
			set { SetValue(ref _pokeBus, value); }
		}

		private ObservableCollection<Pokemon> _pokeList;

		public ObservableCollection<Pokemon> PokeList
		{
			get { return _pokeList = _pokeList ?? new ObservableCollection<Pokemon>(); }
			set { SetValue(ref _pokeList, value); }
		}


		public PokemonListViewModel()
		{
			LoadItems();
		}

		private async void LoadItems()
		{ 
			PokeBus = await DependencyService.Get<IPokemonService>().GetAllAsync();

			foreach(Pokemon pk in PokeBus.Results)
			{
				PokeList.Add(pk);
			}
		}
	}
}
